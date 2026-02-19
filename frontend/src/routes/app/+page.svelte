<script lang="ts">
	import { onMount } from 'svelte';
	import { goto } from '$app/navigation';

	onMount(() => {
		const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
		if (isLoggedIn) {
			goto('/app/voting');
		} else {
			goto('/login');
		}
	});
</script>

<p>Redirecting...</p>
