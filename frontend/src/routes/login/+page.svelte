<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';
	import MainContainer from '../../components/MainContainer.svelte';

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

<MainContainer>
	<Topbar />
	<AuthCard title="Login" fields={loginFields}></AuthCard>
</MainContainer>
