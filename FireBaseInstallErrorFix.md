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


IOS при установке ничего ни где не добавлять кроме GoogleService-Info.plist в ios/Runner/ и в Podfile расскоментировать и изменить на:
platform :ios, '10.0'


Очищение если необходимо
sudo gem install cocoapods-deintegrate cocoapods-clean
pod deintegrate
pod clean
rm Podfile

— способ 2 

1. Delete the Pods directory, the /ios/podfile.lock, and the ios/Flutter/Flutter.podspec 
2. Run pod deintegrate 
3. Delete all of the contents inside your DerivedData folder.. you can run rm -rf ~/Library/Developer/Xcode/DerivedData/*  
4. Run flutter clean 
5. Run flutter pub get 
6. Run flutter build ios. Note thas this will also run the pod install command. 
7. Close your editor, and open your Runner.xcworkspace on XCode and run your XCode. Clean your build folder( - xcodebuild clean). If there's an option to update your project settings, accept it.

Спасаемся от бесконечной загрузки:

Open the Podfile inside the ios folder, then add this line inside your target 'Runner' do block:

target 'Runner' do
  pod 'FirebaseFirestore', :git => 'https://github.com/invertase/firestore-ios-sdk-frameworks.git', :tag => '8.9.0'

# ...
end

Соответственно меняем версию на нашу текущую:

pod 'FirebaseFirestore', :git => 'https://github.com/invertase/firestore-ios-sdk-frameworks.git', :tag => ‘8.11.0'
