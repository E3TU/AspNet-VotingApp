<script lang="ts">
	import favicon from '$lib/assets/favicon.svg';
	import '@fontsource-variable/geologica';
	import '../app.css';

	import { fade } from 'svelte/transition';

	let { data, children } = $props();
</script>

<svelte:head>
	<link rel="icon" href={favicon} />
</svelte:head>
<div class="wrapper">
	{#key data.pathname}
		<div class="page" in:fade={{ duration: 400}} out:fade={{ duration: 300 }}>
			{@render children()}
		</div>
	{/key}
</div>

<style>
	.wrapper{
		position: relative;
		min-height: 100vh;
		background-color: var(--bg-black);
	}
	.page{
		position: absolute;
		inset: 0;
	}
</style>