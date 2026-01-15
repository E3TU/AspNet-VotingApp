<script lang="ts">
	let { title = '', children } = $props();
</script>

<div class="card">
	{#if title}
		<h1 class="title">{title}</h1>
	{/if}

	<main class="content">
		{@render children?.()}
	</main>
</div>

<style>
	.card {
		display: flex;
		flex-direction: column;
        align-items: center;
		margin-top: 15rem;
		width: 35rem;
		height: 45rem;
		background-color: var(--nord-dark);
		box-shadow:
			inset 2px 2px 5px rgba(0, 0, 0, 0.2),
			inset -2px -2px 5px rgba(255, 255, 255, 0.1),
			5px 5px 10px rgba(0, 0, 0, 0.3),
			-5px -5px 10px rgba(255, 255, 255, 0.1);
		border: none;
		border-radius: 15px;
	}
	.title {
		margin-top: 3rem;
		color: var(--text-primary);
	}
</style>
