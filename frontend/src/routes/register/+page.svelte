<script lang="ts">
	import Topbar from '../../components/Topbar.svelte';
	import AuthCard from '../../components/AuthCard.svelte';
</script>

<div class="register-page">
	<Topbar />
	<h3 class="already-user">Already have an account?&nbsp<a class="login">Log In</a></h3>
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
	.already-user {
		color: var(--text-primary);
		margin-left: auto;
		margin-right: 2rem;
		margin-top: 1rem;
	}
	.login{
		color: var(--neon);
		cursor: pointer;
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
		color: var(--text-primary);
	}
	input {
		width: 20rem;
		border-radius: 30px;
		border: 2px solid transparent;
		padding: 1rem;
		background-color: var(--nord-dark);
		color: var(--text-primary);
		outline: none;
		font-size: 1rem;
		box-shadow:
			inset 2px 2px 5px rgba(0, 0, 0, 0.2),
			inset -2px -2px 5px rgba(255, 255, 255, 0.055),
			5px 5px 10px rgba(0, 0, 0, 0.3),
			-5px -5px 10px rgba(255, 255, 255, 0.054);
		transition: 0.1s;
	}
	input::placeholder {
		color: var(--text-secondary);
	}
	input:focus {
		border: 2px solid var(--neon);
		box-shadow:
			0 0 20px var(--neon-glow),
			inset 0 1px 6px var(--neon-glow);
		transition: 0.1s;
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
