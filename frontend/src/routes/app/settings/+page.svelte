<script lang="ts">
	import MainContainer from '../../../components/MainContainer.svelte';
	import Icon from '@iconify/svelte';

	const goBack : any = () => {
		history.back();
	}
</script>

<MainContainer>
	<div class="settings-container">
		<div class="top-wrapper">
			<a href="#" onclick={goBack}><Icon class="back-btn" icon="weui:back-filled" width="32" height="32" /></a>
			<h1>Settings</h1>
		</div>
	</div>
</MainContainer>

<style>
	.settings-container {
		display: flex;
		background-color: var(--nord-dark);
		border-radius: 18px;
		width: 80rem;
		height: 50rem;
		margin: auto;
		padding: 2rem;
		box-shadow: rgba(0, 0, 0, 0.56) 0px 22px 70px 4px;
	}
	.top-wrapper{
		display: flex;
		flex-direction: row;
		width: 100%;
		height: 2rem;
		align-items: center;
	}
	:global(.back-btn){
		color: var(--neon);
	}
	h1 {
		color: var(--text-primary);
	}
</style>
