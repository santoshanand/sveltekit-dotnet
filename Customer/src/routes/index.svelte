<script context="module" lang="ts">
	export const prerender = true;
</script>

<script lang="ts">

	import { onMount } from 'svelte'
	const API = import.meta.env.VITE_API_URL;
	onMount(() => {
		fetch(`${API}/user`)
		.then(response => response.json())
		.then(data => console.log(data));
	})

</script>

<svelte:head>
	<title>Home</title>
</svelte:head>

<section>
	{API}
</section>

