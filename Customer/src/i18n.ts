import { register, init, getLocaleFromNavigator } from 'svelte-i18n';

register('en', () => import('$lib/locale/en.json'));
register('hi', () => import('$lib/locale/hi.json'));
// en, en-US and pt are not available yet

init({
  fallbackLocale: 'en',
  initialLocale: getLocaleFromNavigator(),
});