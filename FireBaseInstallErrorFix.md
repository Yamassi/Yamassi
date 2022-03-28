Android:

Solution :
In the Android Studio File > Project Structure
1. Now a window pops up
2. Within that select Project Settings/Project
3. Make sure Project SDK is set to latest platform as mentioned in the pic below
￼
4. Next select Project Settings/Modules sub tab
5. There select the lastest Android SDK as you did in step-3
￼
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
