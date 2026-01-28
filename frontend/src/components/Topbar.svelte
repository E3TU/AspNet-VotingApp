<script lang="ts">
	import Icon from '@iconify/svelte';
</script>

<header class="topbar">
	<nav class="navbar">
		<ul class="nav-links">
			<li>Voting</li>
			<li>Poll Creation</li>
		</ul>
		<button id="user-btn"
			><Icon class="user-icon" icon="ix:user-profile-filled" width="64" height="64"></Icon></button
		>
	</nav>
</header>

<style>
	.topbar {
		width: 80%;
		height: 5rem;
		margin-top: 1rem;
		border-radius: 15px;
		background: linear-gradient(90deg, var(--nord-dark) 0%, var(--nord-light) 100%);
		box-shadow:
			5px 5px 10px #0b0c10,
			-5px -5px 10px #2b2e3e;
	}
	.navbar {
		display: flex;
		width: 100%;
		flex-direction: row;
		align-items: center;
		justify-content: flex-end;
		height: 100%;
	}
	.nav-links {
		display: inline-flex;
		flex-direction: row;
		list-style: none;
		gap: 2rem;
		padding-right: 5rem;
	}
	.nav-links li {
		color: var(--text-primary);
		font-size: 1.25rem;
		cursor: pointer;
		transition: 0.5s;
	}
	.nav-links li:hover {
		color: var(--neon);
		transition: 0.5s;
	}
	:global(.user-icon) {
		color: var(--neon);
	}
	#user-btn {
		background-color: transparent;
		border: none;
		padding-right: 3rem;
		cursor: pointer;
	}
</style>
