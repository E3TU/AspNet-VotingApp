<script lang="ts">
	interface Field {
		name: string;
		label: string;
		type: string;
		placeholder?: string;
		required?: boolean;
	}
	interface Props {
		title?: string;
		fields?: Field[];
		onSubmit?: (data: Record<string, string>) => void;
	}
	let { title = 'Form', fields = [], onSubmit = () => {} } = $props();
	let formData = $state<Record<string, string>>({});
	$effect(() => {
		fields.forEach((f) => {
			if (!(f.name in formData)) {
				formData[f.name] = '';
			}
		});
	});
	const handleSubmit = (e: Event) => {
		e.preventDefault();
		onSubmit(formData);
	};
</script>

<form onsubmit={handleSubmit}>
	<div class="card">
		<h1>{title}</h1>
		{#each fields as field}
			<label for={field.name}>{field.label}</label>
			<input
				id={field.name}
				type={field.type}
				bind:value={formData[field.name]}
				placeholder={field.placeholder}
				required={field.required || false}
			/>
		{/each}
		<button type="submit">{title}</button>
	</div>
</form>

<style>
	.card {
		display: flex;
		flex-direction: column;
		align-items: center;
		margin-top: 15rem;
		width: 35rem;
		height: 45rem;
		background-color: var(--nord-dark);
		box-shadow:
			inset 2px 2px 5px rgba(0, 0, 0, 0.2),
			inset -2px -2px 5px rgba(255, 255, 255, 0.1),
			5px 5px 10px rgba(0, 0, 0, 0.3),
			-5px -5px 10px rgba(255, 255, 255, 0.1);
		border: none;
		border-radius: 15px;
	}
	h1 {
		margin-top: 3rem;
		color: var(--text-primary);
	}
	form {
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
	button {
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
