<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';
	import MainContainer from '../../components/MainContainer.svelte';
	import { login } from '$lib/api';
	import { goto } from '$app/navigation';

	const loginFields = [
		{ name: 'email', label: 'Email', type: 'email', placeholder: 'Enter email', required: true },
		{
			name: 'password',
			label: 'Password',
			type: 'password',
			placeholder: 'Enter password',
			required: true
		}
	];

	let error = $state('');
	let loading = $state(false);

	async function handleLogin(formData: Record<string, string>) {
		error = '';
		loading = true;
		console.log('Attempting login with:', formData.email);
		
		try {
			const result = await login({
				email: formData.email,
				password: formData.password
			});

			console.log('Login result:', result);

			if (result.error) {
				error = result.error;
			} else {
				localStorage.setItem('isLoggedIn', 'true');
				goto('/app');
			}
		} catch (err) {
			console.error('Login error:', err);
			error = 'Failed to login. Please check your credentials.';
		} finally {
			loading = false;
		}
	}
</script>

<MainContainer>
	<Topbar />
	<div class="login-container">
		<AuthCard title="Login" fields={loginFields} onSubmit={handleLogin}></AuthCard>
		{#if error}
			<div class="error">{error}</div>
		{/if}
		{#if loading}
			<div class="loading">Logging in...</div>
		{/if}
	</div>
</MainContainer>

<style>
	.login-container {
		display: flex;
		flex-direction: column;
		align-items: center;
	}
	.error {
		color: #ff4545;
		margin-top: 1rem;
		padding: 0.5rem 1rem;
		background: rgba(255, 69, 69, 0.1);
		border-radius: 8px;
	}
	.loading {
		color: var(--neon);
		margin-top: 1rem;
	}
</style>
