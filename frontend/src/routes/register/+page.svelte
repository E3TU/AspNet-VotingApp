<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';
	import MainContainer from '../../components/MainContainer.svelte';
	import { register } from '$lib/api';
	import { goto } from '$app/navigation';

	const registerFields = [
		{ name: 'name', label: 'Name', type: 'text', placeholder: 'Enter your name', required: true },
		{
			name: 'email',
			label: 'Email',
			type: 'email',
			placeholder: 'Enter your email',
			required: true
		},
		{
			name: 'password',
			label: 'Password',
			type: 'password',
			placeholder: 'Enter password',
			required: true
		},
		{
			name: 'confirmpassword',
			label: 'Confirm password',
			type: 'password',
			placeholder: 'Confirm password',
			required: true
		}
	];

	let error = $state('');
	let loading = $state(false);

	async function handleRegister(formData: Record<string, string>) {
		error = '';
		
		if (formData.password !== formData.confirmpassword) {
			error = 'Passwords do not match';
			return;
		}

		loading = true;
		console.log('Attempting register with:', formData.email, formData.name);
		
		try {
			const result = await register({
				email: formData.email,
				password: formData.password,
				name: formData.name
			});

			console.log('Register result:', result);

			if (result.error) {
				error = result.error;
			} else {
				goto('/login');
			}
		} catch (err) {
			console.error('Register error:', err);
			error = 'Failed to register. Please try again.';
		} finally {
			loading = false;
		}
	}
</script>

<MainContainer>
	<Topbar />
	<div class="register-container">
		<AuthCard title="Register" fields={registerFields} onSubmit={handleRegister}></AuthCard>
		{#if error}
			<div class="error">{error}</div>
		{/if}
		{#if loading}
			<div class="loading">Registering...</div>
		{/if}
	</div>
</MainContainer>

<style>
	.register-container {
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
