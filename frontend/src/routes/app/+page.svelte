<script lang="ts">
	import MainContainer from '../../components/MainContainer.svelte';
	import Topbar from '../../components/Topbar.svelte';

	let pollTitle: string = 'Test';
</script>

<MainContainer>
	<Topbar></Topbar>
	<div class="container">
		<div class="poll-container">
			<h1 class="main-title">Active Polls</h1>
			<div class="poll">
				<h1 class="poll-title">{pollTitle}</h1>
				<p class="poll-description">Test test test 1234</p>
				<button class="vote-btn">Choice A</button>
				<button class="vote-btn">Choice B</button>
			</div>
			<div class="poll">
				<h1 class="poll-title">{pollTitle}</h1>
			</div>
			<div class="poll">
				<h1 class="poll-title">{pollTitle}</h1>
			</div>
		</div>
		<div class="right-side">
			<div class="small-box">
				<h1>Your Voting History</h1>
				<div class="voted-poll">
					<h2>Test Poll 1</h2>
					<p>Poll to test the voting function</p>
				</div>
				<div class="voted-poll">
					<h2>Test Poll 2</h2>
					<p>Poll to test the voting function</p>
				</div>
				<div class="voted-poll">
					<h2>Test Poll 3</h2>
					<p>Poll to test the voting function</p>
				</div>
			</div>
			<div class="small-box"></div>
			<div class="small-box"></div>
		</div>
	</div>
</MainContainer>

<style>
	.container {
		margin-top: 5rem;
		/* background-color: var(--nord-dark); */
		height: 65rem;
		width: 120rem;
		display: flex;
		justify-content: space-between;
		gap: 2rem;
		border-radius: 18px;
	}
	.poll-container {
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

		display: flex;
		flex-direction: column;
		align-items: center;
		gap: 2rem;
	}
	.main-title {
		color: var(--text-primary);
		margin: 2rem;
	}
	.poll {
		height: 17rem;
		width: 90%;
		background-color: var(--nord-dark-alternative);
		box-shadow: rgba(0, 0, 0, 0.56) 0px 22px 70px 4px;
		border-radius: 12px;
		/* border: 2px solid transparent;
		background:
			linear-gradient(to right, var(--nord-dark), var(--nord-dark)) padding-box,
			linear-gradient(to right, var(--neon), var(--neon-glow)) border-box;
		background-clip: padding-box, border-box;
		background-origin: padding-box, border-box; */
		padding: 2rem;
	}
	.poll-title {
		color: var(--text-primary);
	}
	.poll-description {
		color: var(--text-secondary);
	}
	.vote-btn {
		margin-top: 1rem;
		margin-right: 1rem;
		padding: 1rem 5rem;
		font-size: 1rem;
		background-color: var(--neon);
		border: none;
		border-radius: 30px;
		box-shadow:
			0 8px 24px rgba(6, 9, 12, 0.6),
			0 0 30px var(--neon-glow);
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
		padding: 2rem;
	}
	.small-box h1 {
		color: var(--text-primary);
	}
	.small-box h2{
		color: var(--text-secondary);
	}
	.small-box p{
		color: var(--text-secondary);
	}
	.voted-poll{
		padding-top: 1rem;
		padding-bottom: 1rem;
		border-bottom: 2px solid var(--neon);
	}
	#voting-history {
	}
</style>
