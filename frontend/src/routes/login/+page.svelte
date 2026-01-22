<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';

	const loginFields = [
		{ name: 'email', label: 'Email', type: 'email', placeholder: 'Enter email', required: true },
		{
			name: 'password',
			label: 'Password',
			type: 'email',
			placeholder: 'Enter password',
			required: true
		}
	];
</script>

<div class="login-page">
	<Topbar/>
	<AuthCard title="Login" fields={loginFields}></AuthCard>
</div>

<style>
	.login-page {
		display: flex;
		flex-direction: column;
		align-items: center;
		height: 100vh;
		width: 100%;
		background-color: var(--bg-black);
		background-image: url('ffflux.svg');
		background-repeat: no-repeat;
		background-position: center;
		background-size: contain;
	}
</style>
