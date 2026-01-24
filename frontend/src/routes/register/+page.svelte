<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';

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
			label: 'Confirmpassword',
			type: 'confirmpassword',
			placeholder: 'Confirm password',
			required: true
		}
	];
</script>

<div class="register-page">
	<Topbar />
	<AuthCard title="Register" fields={registerFields}></AuthCard>
</div>

<style>
	.register-page {
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
