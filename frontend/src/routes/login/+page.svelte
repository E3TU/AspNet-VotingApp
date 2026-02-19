<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';
	import MainContainer from '../../components/MainContainer.svelte';

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
</script>

<MainContainer>
	<Topbar />
	<div class="login-container">
		<AuthCard title="Login" fields={loginFields}></AuthCard>
		</div>
</MainContainer>

<style>
	.login-container {
		display: flex;
		flex-direction: column;
		align-items: center;
	}
</style>
