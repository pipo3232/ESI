// Opcional: Puedes ajustar la velocidad de desplazamiento modificando la duración del keyframe 'moveImage' en el CSS

// Obtén todas las imágenes que se moverán
const movingImages = document.querySelectorAll('.moving-image');

// Aplica un desplazamiento inicial aleatorio a cada imagen
movingImages.forEach((image) => {
  const randomOffset = Math.random() * 100;
  image.style.animationDelay = `${randomOffset}s`;
});
