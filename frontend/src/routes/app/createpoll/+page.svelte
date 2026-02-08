<script lang="ts">
	import Topbar from '../../../components/Topbar.svelte';
	import MainContainer from '../../../components/MainContainer.svelte';
	import Icon from '@iconify/svelte';
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
				<button id="create-poll-btn">Create Poll</button>
			</div>
		</div>
		<div class="manage-polls">
			<div class="poll-stats-wrapper">
				<h1 class="manage-polls-heading">Manage Polls</h1>
				<div class="poll-stats">
					<p class="total-polls">Total Polls: 15</p>
				</div>
			</div>
			<div class="active-polls-wrapper">
				<div class="active-poll">
					<div class="left-side">
						<h1 class="active-poll-heading">Test</h1>
						<p class="active-indicator">
							<Icon icon="nrk:check-active" width="24" height="24" />Active
						</p>
					</div>
					<div class="right-side">
						<button id="edit-btn" class="active-poll-btn"
							><Icon icon="material-symbols:edit-outline" width="24" height="24" />Edit</button
						>
						<button id="delete-btn" class="active-poll-btn"
							><Icon icon="material-symbols:delete-outline" width="24" height="24" />Delete</button
						>
					</div>
				</div>
				<div class="active-poll">
					<div class="left-side">
						<h1 class="active-poll-heading">Test</h1>
						<p class="inactive-indicator">
							<Icon icon="icomoon-free:blocked" width="24" height="24" />Closed
						</p>
					</div>
					<div class="right-side">
						<button id="edit-btn" class="active-poll-btn"
							><Icon icon="material-symbols:edit-outline" width="24" height="24" />Edit</button
						>
						<button id="delete-btn" class="active-poll-btn"
							><Icon icon="material-symbols:delete-outline" width="24" height="24" />Delete</button
						>
					</div>
				</div>
			</div>
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
	.input-wrapper {
		display: flex;
		flex-direction: column;
		align-items: center;
		flex: 1;
		gap: 1rem;
	}
	input {
		padding: 1rem;
		background-color: var(--nord-dark-alternative);
		border: 2px solid #fff;
		width: 90%;
		border-radius: 10px;
		font-size: 1rem;
		outline: none;
		color: var(--text-primary);
	}
	input::placeholder {
		color: var(--text-secondary);
	}
	input:focus {
		border: 2px solid var(--neon);
	}
	.divider {
		width: 90%;
		height: 0.2rem;
		background-color: var(--neon);
		border-radius: 30px;
	}
	#create-poll-btn {
		padding: 1.25rem 5rem;
		border-radius: 30px;
		font-size: 1rem;
		border: none;
		background-color: var(--neon);
		color: var(--text-primary);
		box-shadow:
			0 8px 24px rgba(6, 9, 12, 0.6),
			0 0 30px var(--neon-glow);
		cursor: pointer;
		margin-top: 1rem;
	}
	.manage-polls {
		display: flex;
		flex-direction: column;
		background-color: var(--nord-dark);
		flex: 3;
		border-radius: 18px;
		box-shadow:
			2px 2px 10px #115c33,
			-2px -2px 10px #45ffcb;
	}
	.poll-stats-wrapper {
		display: flex;
		flex-direction: row;
		padding: 3rem 5rem;
		justify-content: space-between;
	}
	.poll-stats{
		background-color: var(--nord-dark-alternative);
		border-radius: 18px;
		padding: 1rem;
				box-shadow: rgba(0, 0, 0, 0.56) 0px 22px 70px 4px;

	}
	.total-polls{
		color: var(--text-primary);
	}
	.manage-polls-heading {
		color: var(--text-primary);
		/* margin: 3rem 5rem; */
	}
	.active-polls-wrapper {
		display: flex;
		flex-direction: column;
		align-items: center;
		flex: 1;
		/* background-color: #45ffcb; */
	}
	.active-poll {
		display: flex;
		flex-direction: row;
		background-color: var(--nord-dark-alternative);
		width: 90%;
		height: 10rem;
		border-radius: 18px;
		box-shadow: rgba(0, 0, 0, 0.56) 0px 22px 70px 4px;
		padding: 1rem 2rem;
		margin-top: 2rem;
	}
	.active-poll-heading {
		color: var(--text-primary);
		/* margin: 2rem; */
	}
	.active-indicator {
		display: inline-flex;
		align-items: center;
		color: var(--neon);
		margin-top: 1rem;
		gap: 0.25rem;
	}
	.inactive-indicator {
		display: inline-flex;
		align-items: center;
		color: var(--warning-red);
		margin-top: 1rem;
		gap: 0.25rem;
	}
	.left-side {
		display: flex;
		flex-direction: column;
		flex: 1;
	}
	.right-side {
		display: flex;
		flex-direction: row;
		align-items: center;
		justify-content: flex-end;
		flex: 1;
		gap: 1rem;
	}
	.active-poll-btn {
		border-radius: 30px;
		border: 2px solid var(--neon);
		background-color: transparent;
		color: var(--text-primary);
		padding: 0.75rem 2rem;
		display: inline-flex;
		flex-direction: row;
		align-items: center;
		gap: 0.25rem;
		font-size: 0.9rem;
		cursor: pointer;
		transition: 0.5s;
	}
	#edit-btn:hover {
		color: var(--neon);
		transition: 0.5s;
	}
	#delete-btn:hover {
		color: var(--warning-red);
		transition: 0.5s;
	}
</style>
