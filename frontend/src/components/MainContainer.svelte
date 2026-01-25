<script lang="ts">
    let { children } = $props();
</script>

<div class="main-container">
{@render children?.()}
</div>

<style>
	.main-container {
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
