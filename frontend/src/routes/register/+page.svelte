<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';
</script>

<div class="register-page">
	<Topbar />
	<AuthCard title="Create an account">
		{#snippet children()}
			<form id="register-form">
				<label for="username">Username</label>
				<input id="username" placeholder="Enter username" />
				<label for="email">Email</label>
				<input id="email" placeholder="Enter email" />
				<label for="password">Password</label>
				<input id="password" placeholder="Enter password" />
				<label for="confirm-password">Confirm Password</label>
				<input id="confirm-password" placeholder="Confirm password" />
				<button id="register-btn">Register</button>
			</form>
		{/snippet}
	</AuthCard>
</div>

<style>
	.register-page {
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
	#register-form {
		display: flex;
		flex-direction: column;
		align-items: center;
		width: 100%;
		height: auto;
	}
	label {
		margin-top: 2rem;
		margin-bottom: 1rem;
		text-align: left !important;
		width: 20rem;
		color: white;
	}
	input {
		width: 20rem;
		border-radius: 30px;
		border: none;
		padding: 1rem;
		background-color: var(--nord-dark);
		color: white;
		outline: none;
		font-size: 1rem;
		box-shadow:
			inset 2px 2px 5px rgba(0, 0, 0, 0.2),
			inset -2px -2px 5px rgba(255, 255, 255, 0.055),
			5px 5px 10px rgba(0, 0, 0, 0.3),
			-5px -5px 10px rgba(255, 255, 255, 0.054);
	}
	#register-btn {
		width: 20rem;
		border-radius: 30px;
		padding: 1rem;
		margin-top: 2rem;
		font-size: 1rem;
		color: var(--neon);
		background: linear-gradient(180deg, rgba(43, 231, 127, 0.06), rgba(43, 231, 127, 0.03));
		border: 2px solid #2be77f;
		text-align: center;
		box-shadow:
			0 8px 24px rgba(6, 9, 12, 0.6),
			0 0 30px var(--neon-glow);
		cursor: pointer;
	}
</style>
