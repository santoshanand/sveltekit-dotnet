<script lang="ts" context="module">
	import '$lib/Tailwind/index.svelte'
	import '../app.css';
	import Header from '$lib/Header/index.svelte'

	import { waitLocale } from 'svelte-i18n'

  // export async function load({ page, fetch, session, context }) {
  //   // awaits for the loading of the 'en-US' and 'en' dictionaries
	// 	console.log("Working")
	// 	waitLocale()
  //   return {}
  // }
</script>

<Header/>
<main>
	<slot />
</main>
