import copydir from 'copy-dir';

copydir.sync('build', '../backend/www', {
  utimes: true,  // keep add time and modify time
  mode: true,    // keep file mode
  cover: true    // cover file when exists, default is true
});