<script lang="ts">
	import Topbar from '../../../components/Topbar.svelte';
	import MainContainer from '../../../components/MainContainer.svelte';
</script>

<MainContainer>
	<Topbar />
	<div class="container">
		<div class="create-polls">
			<h1 class="create-polls-heading">Create Poll</h1>
			<div class="input-wrapper">
				<input placeholder="Poll Question" />
				<div class="divider"></div>
				<input placeholder="Option 1" />
				<input placeholder="Option 2" />
			</div>
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
		display: flex;
		flex-direction: column;
		/* align-items: center; */
		background-color: var(--nord-dark);
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
	.input-wrapper{
		display: flex;
		flex-direction: column;
		align-items: center;
		flex: 1;
		gap: 1rem;
	}
	input{
		padding: 1rem;
		background-color: var(--nord-dark-alternative);
		border: 2px solid #fff;
		width: 90%;
		border-radius: 10px;
		font-size: 1rem;
		outline: none;
		color: var(--text-primary);
	}
	input::placeholder{
		color: var(--text-secondary);
	}
	input:focus{
		border: 2px solid var(--neon);
	}
	.divider{
		width: 90%;
		height: 0.2rem;
		background-color: var(--neon);
		border-radius: 30px;
	}
	.manage-polls {
		background-color: var(--nord-dark);
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
	hr{
		border-top: 2px solid var(--neon);
	}
</style>
