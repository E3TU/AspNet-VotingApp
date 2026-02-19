<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';
	import MainContainer from '../../components/MainContainer.svelte';

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
</script>

<MainContainer>
	<Topbar />
	<div class="register-container">
		<AuthCard title="Register" fields={registerFields}></AuthCard>
	</div>
</MainContainer>

<style>
	.register-container {
		display: flex;
		flex-direction: column;
		align-items: center;
	}
</style>
