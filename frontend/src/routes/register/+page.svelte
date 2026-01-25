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
			type: 'confirmpassword',
			placeholder: 'Confirm password',
			required: true
		}
	];
</script>

<MainContainer>
	<Topbar />
	<AuthCard title="Register" fields={registerFields}></AuthCard>
</MainContainer>
