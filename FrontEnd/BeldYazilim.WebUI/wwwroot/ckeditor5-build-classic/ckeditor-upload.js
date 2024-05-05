class MyUploadAdapter {
    constructor(loader) {
        this.loader = loader;
    }

    upload() {
        return this.loader.file
            .then(file => new Promise((resolve, reject) => {
                const reader = new FileReader();

                reader.onload = () => {
                    resolve({ default: reader.result });
                };

                reader.onerror = reject;

                reader.readAsDataURL(file);
            }));
    }
}