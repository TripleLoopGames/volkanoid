// ------------------------------------------------------------------------------
//  _______   _____ ___ ___   _   ___ ___ 
// |_   _\ \ / / _ \ __/ __| /_\ | __| __|
//   | |  \ V /|  _/ _|\__ \/ _ \| _|| _| 
//   |_|   |_| |_| |___|___/_/ \_\_| |___|
// 
// This file has been generated automatically by TypeSafe.
// Any changes to this file may be lost when it is regenerated.
// https://www.stompyrobot.uk/tools/typesafe
// 
// TypeSafe Version: 1.2.2-Unity5
// 
// ------------------------------------------------------------------------------



public sealed class SRResources {
    
    private SRResources() {
    }
    
    private const string _tsInternal = "1.2.2-Unity5";
    
    public static global::TypeSafe.Resource<global::DG.Tweening.Core.DOTweenSettings> DOTweenSettings {
        get {
            return ((global::TypeSafe.Resource<global::DG.Tweening.Core.DOTweenSettings>)(__ts_internal_resources[0]));
        }
    }
    
    public static global::TypeSafe.PrefabResource EventSystem {
        get {
            return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
        }
    }
    
    private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                new global::TypeSafe.Resource<global::DG.Tweening.Core.DOTweenSettings>("DOTweenSettings", "DOTweenSettings"),
                new global::TypeSafe.PrefabResource("EventSystem", "EventSystem")});
    
    public sealed class Menu {
        
        private Menu() {
        }
        
        public static global::TypeSafe.PrefabResource StartBlock {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
            }
        }
        
        public static global::TypeSafe.PrefabResource MainMenu {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
            }
        }
        
        public static global::TypeSafe.PrefabResource Main_Camera {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
            }
        }
        
        public static global::TypeSafe.PrefabResource Scenario {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[3]));
            }
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                    new global::TypeSafe.PrefabResource("StartBlock", "Menu/StartBlock"),
                    new global::TypeSafe.PrefabResource("MainMenu", "Menu/MainMenu"),
                    new global::TypeSafe.PrefabResource("Main Camera", "Menu/Main Camera"),
                    new global::TypeSafe.PrefabResource("Scenario", "Menu/Scenario")});
        
        public sealed class Ui {
            
            private Ui() {
            }
            
            public static global::TypeSafe.PrefabResource EventSystem {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
                }
            }
            
            public static global::TypeSafe.PrefabResource Background {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
                }
            }
            
            public static global::TypeSafe.PrefabResource Canvas {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
                }
            }
            
            public static global::TypeSafe.PrefabResource Title {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[3]));
                }
            }
            
            public static global::TypeSafe.PrefabResource WinGame {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[4]));
                }
            }
            
            public static global::TypeSafe.PrefabResource MainPanel {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[5]));
                }
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                        new global::TypeSafe.PrefabResource("EventSystem", "Menu/Ui/EventSystem"),
                        new global::TypeSafe.PrefabResource("Background", "Menu/Ui/Background"),
                        new global::TypeSafe.PrefabResource("Canvas", "Menu/Ui/Canvas"),
                        new global::TypeSafe.PrefabResource("Title", "Menu/Ui/Title"),
                        new global::TypeSafe.PrefabResource("WinGame", "Menu/Ui/WinGame"),
                        new global::TypeSafe.PrefabResource("MainPanel", "Menu/Ui/MainPanel")});
            
            /// <summary>
            /// Return a list of all resources in this folder.
            /// This method has a very low performance cost, no need to cache the result.
            /// </summary>
            /// <returns>A list of resource objects in this folder.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                return __ts_internal_resources;
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
            
            /// <summary>
            /// Return a list of all resources in this folder and all sub-folders.
            /// The result of this method is cached, so subsequent calls will have very low performance cost.
            /// </summary>
            /// <returns>A list of resource objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                if ((__ts_internal_recursiveLookupCache != null)) {
                    return __ts_internal_recursiveLookupCache;
                }
                global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                tmp.AddRange(GetContents());
                __ts_internal_recursiveLookupCache = tmp;
                return __ts_internal_recursiveLookupCache;
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder.
            /// </summary>
            public static void UnloadAll() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder and subfolders.
            /// </summary>
            private void UnloadAllRecursive() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
            }
        }
        
        /// <summary>
        /// Return a list of all resources in this folder.
        /// This method has a very low performance cost, no need to cache the result.
        /// </summary>
        /// <returns>A list of resource objects in this folder.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
            return __ts_internal_resources;
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
        
        /// <summary>
        /// Return a list of all resources in this folder and all sub-folders.
        /// The result of this method is cached, so subsequent calls will have very low performance cost.
        /// </summary>
        /// <returns>A list of resource objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
            if ((__ts_internal_recursiveLookupCache != null)) {
                return __ts_internal_recursiveLookupCache;
            }
            global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
            tmp.AddRange(GetContents());
            tmp.AddRange(Ui.GetContentsRecursive());
            __ts_internal_recursiveLookupCache = tmp;
            return __ts_internal_recursiveLookupCache;
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder.
        /// </summary>
        public static void UnloadAll() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder and subfolders.
        /// </summary>
        private void UnloadAllRecursive() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
        }
    }
    
    public sealed class Game {
        
        private Game() {
        }
        
        public static global::TypeSafe.PrefabResource Canvas_Transition {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
            }
        }
        
        public static global::TypeSafe.PrefabResource Main_Camera {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
            }
        }
        
        public static global::TypeSafe.PrefabResource BallPool {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
            }
        }
        
        public static global::TypeSafe.PrefabResource BallParticlePool {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[3]));
            }
        }
        
        public static global::TypeSafe.PrefabResource Scenario {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[4]));
            }
        }
        
        public static global::TypeSafe.PrefabResource Player {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[5]));
            }
        }
        
        public static global::TypeSafe.PrefabResource Ball {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[6]));
            }
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                    new global::TypeSafe.PrefabResource("Canvas_Transition", "Game/Canvas_Transition"),
                    new global::TypeSafe.PrefabResource("Main Camera", "Game/Main Camera"),
                    new global::TypeSafe.PrefabResource("BallPool", "Game/BallPool"),
                    new global::TypeSafe.PrefabResource("BallParticlePool", "Game/BallParticlePool"),
                    new global::TypeSafe.PrefabResource("Scenario", "Game/Scenario"),
                    new global::TypeSafe.PrefabResource("Player", "Game/Player"),
                    new global::TypeSafe.PrefabResource("Ball", "Game/Ball")});
        
        public sealed class Levels {
            
            private Levels() {
            }
            
            public static global::TypeSafe.PrefabResource Level_3 {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
                }
            }
            
            public static global::TypeSafe.PrefabResource Level_1 {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
                }
            }
            
            public static global::TypeSafe.PrefabResource Level_2 {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
                }
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                        new global::TypeSafe.PrefabResource("Level_3", "Game/Levels/Level_3"),
                        new global::TypeSafe.PrefabResource("Level_1", "Game/Levels/Level_1"),
                        new global::TypeSafe.PrefabResource("Level_2", "Game/Levels/Level_2")});
            
            public sealed class World_1 {
                
                private World_1() {
                }
                
                public static global::TypeSafe.Resource<global::UnityEngine.TextAsset> Level_3 {
                    get {
                        return ((global::TypeSafe.Resource<global::UnityEngine.TextAsset>)(__ts_internal_resources[0]));
                    }
                }
                
                public static global::TypeSafe.Resource<global::UnityEngine.TextAsset> Level_1 {
                    get {
                        return ((global::TypeSafe.Resource<global::UnityEngine.TextAsset>)(__ts_internal_resources[1]));
                    }
                }
                
                public static global::TypeSafe.Resource<global::UnityEngine.TextAsset> Level_2 {
                    get {
                        return ((global::TypeSafe.Resource<global::UnityEngine.TextAsset>)(__ts_internal_resources[2]));
                    }
                }
                
                private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                            new global::TypeSafe.Resource<global::UnityEngine.TextAsset>("Level_3", "Game/Levels/World_1/Level_3"),
                            new global::TypeSafe.Resource<global::UnityEngine.TextAsset>("Level_1", "Game/Levels/World_1/Level_1"),
                            new global::TypeSafe.Resource<global::UnityEngine.TextAsset>("Level_2", "Game/Levels/World_1/Level_2")});
                
                /// <summary>
                /// Return a list of all resources in this folder.
                /// This method has a very low performance cost, no need to cache the result.
                /// </summary>
                /// <returns>A list of resource objects in this folder.</returns>
                public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                    return __ts_internal_resources;
                }
                
                private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
                
                /// <summary>
                /// Return a list of all resources in this folder and all sub-folders.
                /// The result of this method is cached, so subsequent calls will have very low performance cost.
                /// </summary>
                /// <returns>A list of resource objects in this folder and sub-folders.</returns>
                public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                    if ((__ts_internal_recursiveLookupCache != null)) {
                        return __ts_internal_recursiveLookupCache;
                    }
                    global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                    tmp.AddRange(GetContents());
                    __ts_internal_recursiveLookupCache = tmp;
                    return __ts_internal_recursiveLookupCache;
                }
                
                /// <summary>
                /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
                /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                /// </summary>
                /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
                public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                    where TResource : global::UnityEngine.Object {
                    return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
                }
                
                /// <summary>
                /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
                /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                /// </summary>
                /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
                public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                    where TResource : global::UnityEngine.Object {
                    return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
                }
                
                /// <summary>
                /// Call Unload() on every loaded resource in this folder.
                /// </summary>
                public static void UnloadAll() {
                    global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
                }
                
                /// <summary>
                /// Call Unload() on every loaded resource in this folder and subfolders.
                /// </summary>
                private void UnloadAllRecursive() {
                    global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
                }
            }
            
            /// <summary>
            /// Return a list of all resources in this folder.
            /// This method has a very low performance cost, no need to cache the result.
            /// </summary>
            /// <returns>A list of resource objects in this folder.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                return __ts_internal_resources;
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
            
            /// <summary>
            /// Return a list of all resources in this folder and all sub-folders.
            /// The result of this method is cached, so subsequent calls will have very low performance cost.
            /// </summary>
            /// <returns>A list of resource objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                if ((__ts_internal_recursiveLookupCache != null)) {
                    return __ts_internal_recursiveLookupCache;
                }
                global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                tmp.AddRange(GetContents());
                tmp.AddRange(World_1.GetContentsRecursive());
                __ts_internal_recursiveLookupCache = tmp;
                return __ts_internal_recursiveLookupCache;
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder.
            /// </summary>
            public static void UnloadAll() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder and subfolders.
            /// </summary>
            private void UnloadAllRecursive() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
            }
        }
        
        public sealed class Ui {
            
            private Ui() {
            }
            
            public static global::TypeSafe.PrefabResource WinGameScreen {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
                }
            }
            
            public static global::TypeSafe.PrefabResource EventSystem {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
                }
            }
            
            public static global::TypeSafe.PrefabResource Canvas {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
                }
            }
            
            public static global::TypeSafe.PrefabResource GameOverScreen {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[3]));
                }
            }
            
            public static global::TypeSafe.PrefabResource WinLevel {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[4]));
                }
            }
            
            public static global::TypeSafe.PrefabResource Health {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[5]));
                }
            }
            
            public static global::TypeSafe.PrefabResource Time {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[6]));
                }
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                        new global::TypeSafe.PrefabResource("WinGameScreen", "Game/Ui/WinGameScreen"),
                        new global::TypeSafe.PrefabResource("EventSystem", "Game/Ui/EventSystem"),
                        new global::TypeSafe.PrefabResource("Canvas", "Game/Ui/Canvas"),
                        new global::TypeSafe.PrefabResource("GameOverScreen", "Game/Ui/GameOverScreen"),
                        new global::TypeSafe.PrefabResource("WinLevel", "Game/Ui/WinLevel"),
                        new global::TypeSafe.PrefabResource("Health", "Game/Ui/Health"),
                        new global::TypeSafe.PrefabResource("Time", "Game/Ui/Time")});
            
            /// <summary>
            /// Return a list of all resources in this folder.
            /// This method has a very low performance cost, no need to cache the result.
            /// </summary>
            /// <returns>A list of resource objects in this folder.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                return __ts_internal_resources;
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
            
            /// <summary>
            /// Return a list of all resources in this folder and all sub-folders.
            /// The result of this method is cached, so subsequent calls will have very low performance cost.
            /// </summary>
            /// <returns>A list of resource objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                if ((__ts_internal_recursiveLookupCache != null)) {
                    return __ts_internal_recursiveLookupCache;
                }
                global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                tmp.AddRange(GetContents());
                __ts_internal_recursiveLookupCache = tmp;
                return __ts_internal_recursiveLookupCache;
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder.
            /// </summary>
            public static void UnloadAll() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder and subfolders.
            /// </summary>
            private void UnloadAllRecursive() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
            }
        }
        
        public sealed class Building {
            
            private Building() {
            }
            
            public static global::TypeSafe.PrefabResource Level {
                get {
                    return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
                }
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                        new global::TypeSafe.PrefabResource("Level", "Game/Building/Level")});
            
            public sealed class Pickups {
                
                private Pickups() {
                }
                
                public static global::TypeSafe.PrefabResource heart {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource clock {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource star {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource EmptyPickup {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[3]));
                    }
                }
                
                private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                            new global::TypeSafe.PrefabResource("heart", "Game/Building/Pickups/heart"),
                            new global::TypeSafe.PrefabResource("clock", "Game/Building/Pickups/clock"),
                            new global::TypeSafe.PrefabResource("star", "Game/Building/Pickups/star"),
                            new global::TypeSafe.PrefabResource("EmptyPickup", "Game/Building/Pickups/EmptyPickup")});
                
                /// <summary>
                /// Return a list of all resources in this folder.
                /// This method has a very low performance cost, no need to cache the result.
                /// </summary>
                /// <returns>A list of resource objects in this folder.</returns>
                public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                    return __ts_internal_resources;
                }
                
                private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
                
                /// <summary>
                /// Return a list of all resources in this folder and all sub-folders.
                /// The result of this method is cached, so subsequent calls will have very low performance cost.
                /// </summary>
                /// <returns>A list of resource objects in this folder and sub-folders.</returns>
                public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                    if ((__ts_internal_recursiveLookupCache != null)) {
                        return __ts_internal_recursiveLookupCache;
                    }
                    global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                    tmp.AddRange(GetContents());
                    __ts_internal_recursiveLookupCache = tmp;
                    return __ts_internal_recursiveLookupCache;
                }
                
                /// <summary>
                /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
                /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                /// </summary>
                /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
                public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                    where TResource : global::UnityEngine.Object {
                    return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
                }
                
                /// <summary>
                /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
                /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                /// </summary>
                /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
                public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                    where TResource : global::UnityEngine.Object {
                    return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
                }
                
                /// <summary>
                /// Call Unload() on every loaded resource in this folder.
                /// </summary>
                public static void UnloadAll() {
                    global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
                }
                
                /// <summary>
                /// Call Unload() on every loaded resource in this folder and subfolders.
                /// </summary>
                private void UnloadAllRecursive() {
                    global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
                }
            }
            
            public sealed class Blocks {
                
                private Blocks() {
                }
                
                public static global::TypeSafe.PrefabResource cloak {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource prize {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource metal {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource hardIce {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[3]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource bomb {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[4]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource ice {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[5]));
                    }
                }
                
                public static global::TypeSafe.PrefabResource rock {
                    get {
                        return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[6]));
                    }
                }
                
                private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                            new global::TypeSafe.PrefabResource("cloak", "Game/Building/Blocks/cloak"),
                            new global::TypeSafe.PrefabResource("prize", "Game/Building/Blocks/prize"),
                            new global::TypeSafe.PrefabResource("metal", "Game/Building/Blocks/metal"),
                            new global::TypeSafe.PrefabResource("hardIce", "Game/Building/Blocks/hardIce"),
                            new global::TypeSafe.PrefabResource("bomb", "Game/Building/Blocks/bomb"),
                            new global::TypeSafe.PrefabResource("ice", "Game/Building/Blocks/ice"),
                            new global::TypeSafe.PrefabResource("rock", "Game/Building/Blocks/rock")});
                
                /// <summary>
                /// Return a list of all resources in this folder.
                /// This method has a very low performance cost, no need to cache the result.
                /// </summary>
                /// <returns>A list of resource objects in this folder.</returns>
                public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                    return __ts_internal_resources;
                }
                
                private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
                
                /// <summary>
                /// Return a list of all resources in this folder and all sub-folders.
                /// The result of this method is cached, so subsequent calls will have very low performance cost.
                /// </summary>
                /// <returns>A list of resource objects in this folder and sub-folders.</returns>
                public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                    if ((__ts_internal_recursiveLookupCache != null)) {
                        return __ts_internal_recursiveLookupCache;
                    }
                    global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                    tmp.AddRange(GetContents());
                    __ts_internal_recursiveLookupCache = tmp;
                    return __ts_internal_recursiveLookupCache;
                }
                
                /// <summary>
                /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
                /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                /// </summary>
                /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
                public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                    where TResource : global::UnityEngine.Object {
                    return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
                }
                
                /// <summary>
                /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
                /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                /// </summary>
                /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
                public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                    where TResource : global::UnityEngine.Object {
                    return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
                }
                
                /// <summary>
                /// Call Unload() on every loaded resource in this folder.
                /// </summary>
                public static void UnloadAll() {
                    global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
                }
                
                /// <summary>
                /// Call Unload() on every loaded resource in this folder and subfolders.
                /// </summary>
                private void UnloadAllRecursive() {
                    global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
                }
            }
            
            /// <summary>
            /// Return a list of all resources in this folder.
            /// This method has a very low performance cost, no need to cache the result.
            /// </summary>
            /// <returns>A list of resource objects in this folder.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                return __ts_internal_resources;
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
            
            /// <summary>
            /// Return a list of all resources in this folder and all sub-folders.
            /// The result of this method is cached, so subsequent calls will have very low performance cost.
            /// </summary>
            /// <returns>A list of resource objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                if ((__ts_internal_recursiveLookupCache != null)) {
                    return __ts_internal_recursiveLookupCache;
                }
                global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                tmp.AddRange(GetContents());
                tmp.AddRange(Pickups.GetContentsRecursive());
                tmp.AddRange(Blocks.GetContentsRecursive());
                __ts_internal_recursiveLookupCache = tmp;
                return __ts_internal_recursiveLookupCache;
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder.
            /// </summary>
            public static void UnloadAll() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder and subfolders.
            /// </summary>
            private void UnloadAllRecursive() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
            }
        }
        
        /// <summary>
        /// Return a list of all resources in this folder.
        /// This method has a very low performance cost, no need to cache the result.
        /// </summary>
        /// <returns>A list of resource objects in this folder.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
            return __ts_internal_resources;
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
        
        /// <summary>
        /// Return a list of all resources in this folder and all sub-folders.
        /// The result of this method is cached, so subsequent calls will have very low performance cost.
        /// </summary>
        /// <returns>A list of resource objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
            if ((__ts_internal_recursiveLookupCache != null)) {
                return __ts_internal_recursiveLookupCache;
            }
            global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
            tmp.AddRange(GetContents());
            tmp.AddRange(Levels.GetContentsRecursive());
            tmp.AddRange(Ui.GetContentsRecursive());
            tmp.AddRange(Building.GetContentsRecursive());
            __ts_internal_recursiveLookupCache = tmp;
            return __ts_internal_recursiveLookupCache;
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder.
        /// </summary>
        public static void UnloadAll() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder and subfolders.
        /// </summary>
        private void UnloadAllRecursive() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
        }
    }
    
    public sealed class Audio {
        
        private Audio() {
        }
        
        public static global::TypeSafe.PrefabResource SoundCentralPool {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
            }
        }
        
        public static global::TypeSafe.PrefabResource EffectPlayer {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
            }
        }
        
        public static global::TypeSafe.PrefabResource MusicPlayer {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
            }
        }
        
        public static global::TypeSafe.PrefabResource SoundPlayerPool {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[3]));
            }
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                    new global::TypeSafe.PrefabResource("SoundCentralPool", "Audio/SoundCentralPool"),
                    new global::TypeSafe.PrefabResource("EffectPlayer", "Audio/EffectPlayer"),
                    new global::TypeSafe.PrefabResource("MusicPlayer", "Audio/MusicPlayer"),
                    new global::TypeSafe.PrefabResource("SoundPlayerPool", "Audio/SoundPlayerPool")});
        
        public sealed class Music {
            
            private Music() {
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> VolkanoidTheme {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[0]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> VictoryTheme {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[1]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> DefeatTheme {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[2]));
                }
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("VolkanoidTheme", "Audio/Music/VolkanoidTheme"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("VictoryTheme", "Audio/Music/VictoryTheme"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("DefeatTheme", "Audio/Music/DefeatTheme")});
            
            /// <summary>
            /// Return a list of all resources in this folder.
            /// This method has a very low performance cost, no need to cache the result.
            /// </summary>
            /// <returns>A list of resource objects in this folder.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                return __ts_internal_resources;
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
            
            /// <summary>
            /// Return a list of all resources in this folder and all sub-folders.
            /// The result of this method is cached, so subsequent calls will have very low performance cost.
            /// </summary>
            /// <returns>A list of resource objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                if ((__ts_internal_recursiveLookupCache != null)) {
                    return __ts_internal_recursiveLookupCache;
                }
                global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                tmp.AddRange(GetContents());
                __ts_internal_recursiveLookupCache = tmp;
                return __ts_internal_recursiveLookupCache;
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder.
            /// </summary>
            public static void UnloadAll() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder and subfolders.
            /// </summary>
            private void UnloadAllRecursive() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
            }
        }
        
        public sealed class Effects {
            
            private Effects() {
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> ReboteProyectil {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[0]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> WallHit {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[1]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> Invincibility {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[2]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> Confirm {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[3]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> VolcanoShot {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[4]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> Damage {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[5]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> tick {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[6]));
                }
            }
            
            public static global::TypeSafe.Resource<global::UnityEngine.AudioClip> Icebreak {
                get {
                    return ((global::TypeSafe.Resource<global::UnityEngine.AudioClip>)(__ts_internal_resources[7]));
                }
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("ReboteProyectil", "Audio/Effects/ReboteProyectil"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("WallHit", "Audio/Effects/WallHit"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("Invincibility", "Audio/Effects/Invincibility"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("Confirm", "Audio/Effects/Confirm"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("VolcanoShot", "Audio/Effects/VolcanoShot"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("Damage", "Audio/Effects/Damage"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("tick", "Audio/Effects/tick"),
                        new global::TypeSafe.Resource<global::UnityEngine.AudioClip>("Icebreak", "Audio/Effects/Icebreak")});
            
            /// <summary>
            /// Return a list of all resources in this folder.
            /// This method has a very low performance cost, no need to cache the result.
            /// </summary>
            /// <returns>A list of resource objects in this folder.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                return __ts_internal_resources;
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
            
            /// <summary>
            /// Return a list of all resources in this folder and all sub-folders.
            /// The result of this method is cached, so subsequent calls will have very low performance cost.
            /// </summary>
            /// <returns>A list of resource objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                if ((__ts_internal_recursiveLookupCache != null)) {
                    return __ts_internal_recursiveLookupCache;
                }
                global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                tmp.AddRange(GetContents());
                __ts_internal_recursiveLookupCache = tmp;
                return __ts_internal_recursiveLookupCache;
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder.
            /// </summary>
            public static void UnloadAll() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder and subfolders.
            /// </summary>
            private void UnloadAllRecursive() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
            }
        }
        
        /// <summary>
        /// Return a list of all resources in this folder.
        /// This method has a very low performance cost, no need to cache the result.
        /// </summary>
        /// <returns>A list of resource objects in this folder.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
            return __ts_internal_resources;
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
        
        /// <summary>
        /// Return a list of all resources in this folder and all sub-folders.
        /// The result of this method is cached, so subsequent calls will have very low performance cost.
        /// </summary>
        /// <returns>A list of resource objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
            if ((__ts_internal_recursiveLookupCache != null)) {
                return __ts_internal_recursiveLookupCache;
            }
            global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
            tmp.AddRange(GetContents());
            tmp.AddRange(Music.GetContentsRecursive());
            tmp.AddRange(Effects.GetContentsRecursive());
            __ts_internal_recursiveLookupCache = tmp;
            return __ts_internal_recursiveLookupCache;
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder.
        /// </summary>
        public static void UnloadAll() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder and subfolders.
        /// </summary>
        private void UnloadAllRecursive() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
        }
    }
    
    public sealed class Core {
        
        private Core() {
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[0]);
        
        public sealed class Particles {
            
            private Particles() {
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[0]);
            
            public sealed class SpikeExplosionP {
                
                private SpikeExplosionP() {
                }
                
                private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[0]);
                
                public sealed class Material {
                    
                    private Material() {
                    }
                    
                    public static global::TypeSafe.Resource<global::UnityEngine.Sprite> smoke {
                        get {
                            return ((global::TypeSafe.Resource<global::UnityEngine.Sprite>)(__ts_internal_resources[0]));
                        }
                    }
                    
                    public static global::TypeSafe.Resource<global::UnityEngine.Sprite> Shockwave {
                        get {
                            return ((global::TypeSafe.Resource<global::UnityEngine.Sprite>)(__ts_internal_resources[1]));
                        }
                    }
                    
                    public static global::TypeSafe.Resource<global::UnityEngine.Material> spikeSmoke {
                        get {
                            return ((global::TypeSafe.Resource<global::UnityEngine.Material>)(__ts_internal_resources[2]));
                        }
                    }
                    
                    public static global::TypeSafe.Resource<global::UnityEngine.Material> spikeShock {
                        get {
                            return ((global::TypeSafe.Resource<global::UnityEngine.Material>)(__ts_internal_resources[3]));
                        }
                    }
                    
                    private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                                new global::TypeSafe.Resource<global::UnityEngine.Sprite>("smoke", "Core/Particles/SpikeExplosionP/Material/smoke"),
                                new global::TypeSafe.Resource<global::UnityEngine.Sprite>("Shockwave", "Core/Particles/SpikeExplosionP/Material/Shockwave"),
                                new global::TypeSafe.Resource<global::UnityEngine.Material>("spikeSmoke", "Core/Particles/SpikeExplosionP/Material/spikeSmoke"),
                                new global::TypeSafe.Resource<global::UnityEngine.Material>("spikeShock", "Core/Particles/SpikeExplosionP/Material/spikeShock")});
                    
                    /// <summary>
                    /// Return a list of all resources in this folder.
                    /// This method has a very low performance cost, no need to cache the result.
                    /// </summary>
                    /// <returns>A list of resource objects in this folder.</returns>
                    public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                        return __ts_internal_resources;
                    }
                    
                    private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
                    
                    /// <summary>
                    /// Return a list of all resources in this folder and all sub-folders.
                    /// The result of this method is cached, so subsequent calls will have very low performance cost.
                    /// </summary>
                    /// <returns>A list of resource objects in this folder and sub-folders.</returns>
                    public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                        if ((__ts_internal_recursiveLookupCache != null)) {
                            return __ts_internal_recursiveLookupCache;
                        }
                        global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                        tmp.AddRange(GetContents());
                        __ts_internal_recursiveLookupCache = tmp;
                        return __ts_internal_recursiveLookupCache;
                    }
                    
                    /// <summary>
                    /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
                    /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                    /// </summary>
                    /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
                    public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                        where TResource : global::UnityEngine.Object {
                        return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
                    }
                    
                    /// <summary>
                    /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
                    /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                    /// </summary>
                    /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
                    public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                        where TResource : global::UnityEngine.Object {
                        return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
                    }
                    
                    /// <summary>
                    /// Call Unload() on every loaded resource in this folder.
                    /// </summary>
                    public static void UnloadAll() {
                        global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
                    }
                    
                    /// <summary>
                    /// Call Unload() on every loaded resource in this folder and subfolders.
                    /// </summary>
                    private void UnloadAllRecursive() {
                        global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
                    }
                }
                
                /// <summary>
                /// Return a list of all resources in this folder.
                /// This method has a very low performance cost, no need to cache the result.
                /// </summary>
                /// <returns>A list of resource objects in this folder.</returns>
                public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                    return __ts_internal_resources;
                }
                
                private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
                
                /// <summary>
                /// Return a list of all resources in this folder and all sub-folders.
                /// The result of this method is cached, so subsequent calls will have very low performance cost.
                /// </summary>
                /// <returns>A list of resource objects in this folder and sub-folders.</returns>
                public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                    if ((__ts_internal_recursiveLookupCache != null)) {
                        return __ts_internal_recursiveLookupCache;
                    }
                    global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                    tmp.AddRange(GetContents());
                    tmp.AddRange(Material.GetContentsRecursive());
                    __ts_internal_recursiveLookupCache = tmp;
                    return __ts_internal_recursiveLookupCache;
                }
                
                /// <summary>
                /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
                /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                /// </summary>
                /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
                public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                    where TResource : global::UnityEngine.Object {
                    return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
                }
                
                /// <summary>
                /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
                /// This method does not cache the result, so you should cache the result yourself if you will use it often.
                /// </summary>
                /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
                public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                    where TResource : global::UnityEngine.Object {
                    return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
                }
                
                /// <summary>
                /// Call Unload() on every loaded resource in this folder.
                /// </summary>
                public static void UnloadAll() {
                    global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
                }
                
                /// <summary>
                /// Call Unload() on every loaded resource in this folder and subfolders.
                /// </summary>
                private void UnloadAllRecursive() {
                    global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
                }
            }
            
            /// <summary>
            /// Return a list of all resources in this folder.
            /// This method has a very low performance cost, no need to cache the result.
            /// </summary>
            /// <returns>A list of resource objects in this folder.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
                return __ts_internal_resources;
            }
            
            private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
            
            /// <summary>
            /// Return a list of all resources in this folder and all sub-folders.
            /// The result of this method is cached, so subsequent calls will have very low performance cost.
            /// </summary>
            /// <returns>A list of resource objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
                if ((__ts_internal_recursiveLookupCache != null)) {
                    return __ts_internal_recursiveLookupCache;
                }
                global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
                tmp.AddRange(GetContents());
                tmp.AddRange(SpikeExplosionP.GetContentsRecursive());
                __ts_internal_recursiveLookupCache = tmp;
                return __ts_internal_recursiveLookupCache;
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
            }
            
            /// <summary>
            /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
            /// This method does not cache the result, so you should cache the result yourself if you will use it often.
            /// </summary>
            /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
            public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
                where TResource : global::UnityEngine.Object {
                return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder.
            /// </summary>
            public static void UnloadAll() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
            }
            
            /// <summary>
            /// Call Unload() on every loaded resource in this folder and subfolders.
            /// </summary>
            private void UnloadAllRecursive() {
                global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
            }
        }
        
        /// <summary>
        /// Return a list of all resources in this folder.
        /// This method has a very low performance cost, no need to cache the result.
        /// </summary>
        /// <returns>A list of resource objects in this folder.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
            return __ts_internal_resources;
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
        
        /// <summary>
        /// Return a list of all resources in this folder and all sub-folders.
        /// The result of this method is cached, so subsequent calls will have very low performance cost.
        /// </summary>
        /// <returns>A list of resource objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
            if ((__ts_internal_recursiveLookupCache != null)) {
                return __ts_internal_recursiveLookupCache;
            }
            global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
            tmp.AddRange(GetContents());
            tmp.AddRange(Particles.GetContentsRecursive());
            __ts_internal_recursiveLookupCache = tmp;
            return __ts_internal_recursiveLookupCache;
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder.
        /// </summary>
        public static void UnloadAll() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder and subfolders.
        /// </summary>
        private void UnloadAllRecursive() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
        }
    }
    
    public sealed class Particles {
        
        private Particles() {
        }
        
        public static global::TypeSafe.PrefabResource IceBreak {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[0]));
            }
        }
        
        public static global::TypeSafe.PrefabResource Fireball {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[1]));
            }
        }
        
        public static global::TypeSafe.PrefabResource ItemObtained {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[2]));
            }
        }
        
        public static global::TypeSafe.PrefabResource Invincibility {
            get {
                return ((global::TypeSafe.PrefabResource)(__ts_internal_resources[3]));
            }
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_resources = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::TypeSafe.IResource>(new global::TypeSafe.IResource[] {
                    new global::TypeSafe.PrefabResource("IceBreak", "Particles/IceBreak"),
                    new global::TypeSafe.PrefabResource("Fireball", "Particles/Fireball"),
                    new global::TypeSafe.PrefabResource("ItemObtained", "Particles/ItemObtained"),
                    new global::TypeSafe.PrefabResource("Invincibility", "Particles/Invincibility")});
        
        /// <summary>
        /// Return a list of all resources in this folder.
        /// This method has a very low performance cost, no need to cache the result.
        /// </summary>
        /// <returns>A list of resource objects in this folder.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
            return __ts_internal_resources;
        }
        
        private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
        
        /// <summary>
        /// Return a list of all resources in this folder and all sub-folders.
        /// The result of this method is cached, so subsequent calls will have very low performance cost.
        /// </summary>
        /// <returns>A list of resource objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
            if ((__ts_internal_recursiveLookupCache != null)) {
                return __ts_internal_recursiveLookupCache;
            }
            global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
            tmp.AddRange(GetContents());
            __ts_internal_recursiveLookupCache = tmp;
            return __ts_internal_recursiveLookupCache;
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
        }
        
        /// <summary>
        /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
        /// This method does not cache the result, so you should cache the result yourself if you will use it often.
        /// </summary>
        /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
        public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
            where TResource : global::UnityEngine.Object {
            return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder.
        /// </summary>
        public static void UnloadAll() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
        }
        
        /// <summary>
        /// Call Unload() on every loaded resource in this folder and subfolders.
        /// </summary>
        private void UnloadAllRecursive() {
            global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
        }
    }
    
    /// <summary>
    /// Return a list of all resources in this folder.
    /// This method has a very low performance cost, no need to cache the result.
    /// </summary>
    /// <returns>A list of resource objects in this folder.</returns>
    public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContents() {
        return __ts_internal_resources;
    }
    
    private static global::System.Collections.Generic.IList<global::TypeSafe.IResource> __ts_internal_recursiveLookupCache;
    
    /// <summary>
    /// Return a list of all resources in this folder and all sub-folders.
    /// The result of this method is cached, so subsequent calls will have very low performance cost.
    /// </summary>
    /// <returns>A list of resource objects in this folder and sub-folders.</returns>
    public static global::System.Collections.Generic.IList<global::TypeSafe.IResource> GetContentsRecursive() {
        if ((__ts_internal_recursiveLookupCache != null)) {
            return __ts_internal_recursiveLookupCache;
        }
        global::System.Collections.Generic.List<global::TypeSafe.IResource> tmp = new global::System.Collections.Generic.List<global::TypeSafe.IResource>();
        tmp.AddRange(GetContents());
        tmp.AddRange(Menu.GetContentsRecursive());
        tmp.AddRange(Game.GetContentsRecursive());
        tmp.AddRange(Audio.GetContentsRecursive());
        tmp.AddRange(Core.GetContentsRecursive());
        tmp.AddRange(Particles.GetContentsRecursive());
        __ts_internal_recursiveLookupCache = tmp;
        return __ts_internal_recursiveLookupCache;
    }
    
    /// <summary>
    /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref> (does not include sub-folders)
    /// This method does not cache the result, so you should cache the result yourself if you will use it often.
    /// </summary>
    /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder.</returns>
    public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContents<TResource>()
        where TResource : global::UnityEngine.Object {
        return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContents());
    }
    
    /// <summary>
    /// Return a list of all resources in this folder of type <typeparamref>TResource</typeparamref>, including sub-folders.
    /// This method does not cache the result, so you should cache the result yourself if you will use it often.
    /// </summary>
    /// <returns>A list of <typeparamref>TResource</typeparamref> objects in this folder and sub-folders.</returns>
    public static global::System.Collections.Generic.List<global::TypeSafe.Resource<TResource>> GetContentsRecursive<TResource>()
        where TResource : global::UnityEngine.Object {
        return global::TypeSafe.TypeSafeUtil.GetResourcesOfType<TResource>(GetContentsRecursive());
    }
    
    /// <summary>
    /// Call Unload() on every loaded resource in this folder.
    /// </summary>
    public static void UnloadAll() {
        global::TypeSafe.TypeSafeUtil.UnloadAll(GetContents());
    }
    
    /// <summary>
    /// Call Unload() on every loaded resource in this folder and subfolders.
    /// </summary>
    private void UnloadAllRecursive() {
        global::TypeSafe.TypeSafeUtil.UnloadAll(GetContentsRecursive());
    }
}
