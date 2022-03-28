Android:

Solution :
In the Android Studio File > Project Structure
1. Now a window pops up
2. Within that select Project Settings/Project
3. Make sure Project SDK is set to latest platform as mentioned in the pic below
![Project Structure](https://user-images.githubusercontent.com/101391049/160378715-9f3ce4fb-1971-47ae-bd98-4f46cee453f9.png)

4. Next select Project Settings/Modules sub tab
5. There select the lastest Android SDK as you did in step-3
![9 Project Structure](https://user-images.githubusercontent.com/101391049/160378762-e0b35c65-a774-4bce-8ab6-4eaec8d11afa.png)

6. Finally replace the GradleException() with FileNotFoundException() as mentioned below


——\


Multidex

multiDexEnabled true


android {
    defaultConfig {
        ...
        minSdkVersion 15 
        targetSdkVersion 28
        multiDexEnabled true
    }
    ...
}

dependencies {
    implementation "androidx.multidex:multidex:2.0.1"
}
