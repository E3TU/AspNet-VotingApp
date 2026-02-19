<script lang="ts">
	import Icon from '@iconify/svelte';
	import { logout } from '$lib/api';
	import { goto } from '$app/navigation';
	import { page } from '$app/stores';

	let isExpanded = $state(false);
	let isLoggedIn = $state(false);

	$effect(() => {
		isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
	});

	let currentPath = $derived($page.url.pathname);

	function clickHandler() {
		isExpanded = !isExpanded;
	}

	async function handleLogout() {
		localStorage.removeItem('isLoggedIn');
		isLoggedIn = false;
		goto('/login');
	}
</script>

<header class="topbar">
	<nav class="navbar">
		{#if isLoggedIn}
			<ul class="nav-links">
				<li><a href="/app/voting" class:active={currentPath === '/app/voting'}>Voting</a></li>
				<li><a href="/app/createpoll" class:active={currentPath === '/app/createpoll'}>Poll Creation</a></li>
			</ul>
		{/if}

		{#if isLoggedIn}
			<Icon class="user-icon" icon="ix:user-profile-filled" width="64" height="64"></Icon>
			<button onclick={clickHandler} class="dropdown-btn">
				<Icon class="arrow-icon" icon="iconamoon:arrow-down-2" width="32" height="32"></Icon>
			</button>
			{#if isExpanded}
				<div class="dropdown">
					<div class="dropdown-items">
						<a href="/app/settings">Settings</a>
						<button class="logout-btn" onclick={handleLogout}>Logout</button>
					</div>
				</div>
			{/if}
		{:else}
			<div class="auth-links">
				<li><a href="/login" class:active={currentPath === '/login'}>Login</a></li>
				<li><a href="/register" class:active={currentPath === '/register'}>Register</a></li>
			</div>
		{/if}
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
	.nav-links li a {
		font-size: 1.25rem;
		cursor: pointer;
		transition: 0.5s;
		text-decoration: none;
		color: var(--text-primary);
	}
	.nav-links li a:hover {
		color: var(--neon);
		transition: 0.5s;
	}
	.nav-links li a.active {
		color: var(--neon);
		text-decoration: underline;
		text-underline-offset: 5px;
	}
	:global(.user-icon) {
		color: var(--neon);
	}
	:global(.arrow-icon) {
		color: var(--text-primary);
		margin-right: 2rem;
	}
	.dropdown-btn {
		display: flex;
		align-items: center;
		background-color: transparent;
		border: none;
		cursor: pointer;
	}
	.dropdown {
		position: absolute;
		margin-top: 6rem;
		margin-right: 7rem;
	}

	.dropdown-items {
		position: absolute;
		background-color: var(--nord-dark-alternative);
		border-radius: 18px;
	}

	.dropdown-items a {
		color: var(--text-primary);
		padding: 1.25rem;
		text-decoration: none;
		display: flex;
		cursor: pointer;
	}
	.logout-btn {
		color: var(--text-primary);
		padding: 1.25rem;
		background: none;
		border: none;
		cursor: pointer;
		font-size: 1rem;
		text-align: left;
	}
	.logout-btn:hover {
		color: var(--neon);
	}
	.auth-links {
		display: flex;
		flex-direction: row;
		list-style: none;
		gap: 2rem;
		padding-right: 5rem;
	}
	.auth-links li a {
		font-size: 1.25rem;
		cursor: pointer;
		transition: 0.5s;
		text-decoration: none;
		color: var(--text-primary);
	}
	.auth-links li a:hover {
		color: var(--neon);
		transition: 0.5s;
	}
	.auth-links li a.active {
		color: var(--neon);
		text-decoration: underline;
		text-underline-offset: 5px;
	}
</style>
