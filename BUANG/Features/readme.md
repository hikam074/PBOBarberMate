# ./FEATURES
> berisi folder-folder fitur yang dikembangkan

jadi tiap fitur diletakkan di folder dengan nama sesuai fiturnya. Di dalamnya dibuat lagi folder untuk pemisahan dibawah ini, sehingga tiap fitur selalu memiliki folder-folder dibawah ini

| Folder | Isi |
| ----------- | ----------- |
| ./Features/{namaFitur}/Behaviors | File-file per role berisi apa saja yang bisa dilakukan oleh role tertentu |
| ./Features/{namaFitur}/Views | File UserControl untuk tampilan GUI fitur. Murni UI-Event-Render, tidak ambil data, tidak cek role, tidak peduli siapa yang panggil |