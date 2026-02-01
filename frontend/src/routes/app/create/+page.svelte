<script lang="ts">
	import Topbar from '../../../components/Topbar.svelte';
	import MainContainer from '../../../components/MainContainer.svelte';
</script>

<MainContainer>
	<Topbar />
	<div class="container">
		<div class="create-polls">
			<h1 class="create-polls-heading">Create Poll</h1>
		</div>
		<div class="manage-polls">
			<h1 class="manage-polls-heading">Manage Polls</h1>
		</div>
	</div>
</MainContainer>

<style>
	.container {
		display: flex;
		width: 80%;
		height: 60rem;
		/* background-color: aqua; */
		margin: auto;
		gap: 2rem;
	}
	.create-polls {
		background-color: var(--nord-dark-alternative);
		height: 40rem;
		flex: 1;
		border-radius: 18px;
		box-shadow:
			2px 2px 10px #115c33,
			-2px -2px 10px #45ffcb;
	}
	.create-polls-heading {
		color: var(--text-primary);
		margin: 2rem;
	}
	.manage-polls {
		background-color: var(--nord-dark-alternative);
		flex: 3;
		border-radius: 18px;
		box-shadow:
			2px 2px 10px #115c33,
			-2px -2px 10px #45ffcb;
	}
	.manage-polls-heading {
		color: var(--text-primary);
		margin: 2rem;
	}
</style>
