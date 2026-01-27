<script lang="ts">
	import MainContainer from '../../components/MainContainer.svelte';
	import Topbar from '../../components/Topbar.svelte';

	let pollTitle: string = 'Test';
</script>

<MainContainer>
	<Topbar></Topbar>
	<div class="container">
		<div class="big-box">
			<h1>Active Polls</h1>
			<div class="poll-container">
				<div class="poll">
					<h2>{pollTitle}</h2>
				</div>
			</div>
		</div>
		<div class="right-side">
			<div class="small-box"></div>
			<div class="small-box"></div>
			<div class="small-box"></div>
		</div>
	</div>
</MainContainer>

<style>
	.container {
		margin-top: 5rem;
		/* background-color: var(--nord-dark); */
		height: 60rem;
		width: 120rem;
		display: flex;
		justify-content: space-between;
		gap: 2rem;
		border-radius: 18px;
	}
	.big-box {
		flex: 1;
		background-color: var(--nord-dark);
		border-radius: 18px;
		/* border: 2px solid transparent;
		background:
			linear-gradient(to right, var(--nord-dark), var(--nord-dark)) padding-box,
			linear-gradient(to right, var(--neon), var(--neon-glow)) border-box;
		background-clip: padding-box, border-box;
		background-origin: padding-box, border-box; */
		box-shadow:
			2px 2px 10px #115c33,
			-2px -2px 10px #45ffcb;
	}
	.big-box h1 {
		color: var(--text-primary);
		margin: 2rem;
	}
	.big-box h2 {
		color: var(--text-primary);
		margin: 2rem;
	}
	.poll-container {
		display: flex;
		flex-direction: column;
		align-items: center;
		flex: 1;
	}
	.poll {
		height: 17rem;
		width: 90%;
		background-color: var(--nord-dark);
		box-shadow:
			1px 1px 5px #115c33,
			-1px -1px 5px #45ffcb;
			border-radius: 12px;
	}
	.right-side {
		display: flex;
		flex-direction: column;
		gap: 2rem;
	}
	.small-box {
		width: 30rem;
		/* height: 30rem; */
		background-color: aqua;
		border-radius: 18px;
		background-color: var(--nord-dark);
		flex: 1;
		/* border: 2px solid transparent;
		background:
			linear-gradient(to right, var(--nord-dark), var(--nord-dark)) padding-box,
			linear-gradient(to right, var(--neon), var(--neon-glow)) border-box;
		background-clip: padding-box, border-box;
		background-origin: padding-box, border-box;
		box-shadow: rgba(6, 24, 44, 0.4) 0px 0px 0px 2px, rgba(6, 24, 44, 0.65) 0px 4px 6px -1px, rgba(255, 255, 255, 0.08) 0px 1px 0px inset; */
		box-shadow:
			2px 2px 10px #115c33,
			-2px -2px 10px #45ffcb;
	}
</style>
