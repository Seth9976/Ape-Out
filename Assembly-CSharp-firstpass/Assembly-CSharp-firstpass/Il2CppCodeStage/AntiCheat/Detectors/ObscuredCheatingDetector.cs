using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace Il2CppCodeStage.AntiCheat.Detectors
{
	// Token: 0x0200020D RID: 525
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		// Token: 0x06001CDD RID: 7389 RVA: 0x00082D7C File Offset: 0x00080F7C
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredCheatingDetector()
		{
			Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Detectors", "ObscuredCheatingDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr);
			ObscuredCheatingDetector.NativeFieldInfoPtr_ComponentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "ComponentName");
			ObscuredCheatingDetector.NativeFieldInfoPtr_FinalLogPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "FinalLogPrefix");
			ObscuredCheatingDetector.NativeFieldInfoPtr_instancesInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "instancesInScene");
			ObscuredCheatingDetector.NativeFieldInfoPtr_doubleEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "doubleEpsilon");
			ObscuredCheatingDetector.NativeFieldInfoPtr_floatEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "floatEpsilon");
			ObscuredCheatingDetector.NativeFieldInfoPtr_vector2Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "vector2Epsilon");
			ObscuredCheatingDetector.NativeFieldInfoPtr_vector3Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "vector3Epsilon");
			ObscuredCheatingDetector.NativeFieldInfoPtr_quaternionEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "quaternionEpsilon");
			ObscuredCheatingDetector.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, "<Instance>k__BackingField");
			ObscuredCheatingDetector.NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_ObscuredCheatingDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668009);
			ObscuredCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668010);
			ObscuredCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668011);
			ObscuredCheatingDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668012);
			ObscuredCheatingDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668013);
			ObscuredCheatingDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_ObscuredCheatingDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668014);
			ObscuredCheatingDetector.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ObscuredCheatingDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668015);
			ObscuredCheatingDetector.NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_ObscuredCheatingDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668016);
			ObscuredCheatingDetector.NativeMethodInfoPtr_get_ExistsAndIsRunning_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668017);
			ObscuredCheatingDetector.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668018);
			ObscuredCheatingDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668019);
			ObscuredCheatingDetector.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668020);
			ObscuredCheatingDetector.NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668021);
			ObscuredCheatingDetector.NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668022);
			ObscuredCheatingDetector.NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668023);
			ObscuredCheatingDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668024);
			ObscuredCheatingDetector.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr, 100668025);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00082FB4 File Offset: 0x000811B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27926, XrefRangeEnd = 27927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredCheatingDetector AddToSceneOrGetExisting()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_ObscuredCheatingDetector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObscuredCheatingDetector>(intPtr3) : null;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00082FE8 File Offset: 0x000811E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27927, XrefRangeEnd = 27951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00083010 File Offset: 0x00081210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27951, XrefRangeEnd = 27954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00083048 File Offset: 0x00081248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27954, XrefRangeEnd = 27970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00083070 File Offset: 0x00081270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27970, XrefRangeEnd = 27986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x00083098 File Offset: 0x00081298
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x000830CC File Offset: 0x000812CC
		public unsafe static ObscuredCheatingDetector Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27986, XrefRangeEnd = 27988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_ObscuredCheatingDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObscuredCheatingDetector>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27988, XrefRangeEnd = 27990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ObscuredCheatingDetector_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x00083104 File Offset: 0x00081304
		public unsafe static ObscuredCheatingDetector GetOrCreateInstance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 28033, RefRangeEnd = 28035, XrefRangeStart = 27990, XrefRangeEnd = 28033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_ObscuredCheatingDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObscuredCheatingDetector>(intPtr3) : null;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00083138 File Offset: 0x00081338
		public unsafe static bool ExistsAndIsRunning
		{
			[CallerCount(158)]
			[CachedScanResults(RefRangeStart = 28037, RefRangeEnd = 28195, XrefRangeStart = 28035, XrefRangeEnd = 28037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_get_ExistsAndIsRunning_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00083168 File Offset: 0x00081368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28195, XrefRangeEnd = 28198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredCheatingDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObscuredCheatingDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x000831A4 File Offset: 0x000813A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28198, XrefRangeEnd = 28215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000831D8 File Offset: 0x000813D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28215, XrefRangeEnd = 28218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObscuredCheatingDetector.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00083214 File Offset: 0x00081414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28218, XrefRangeEnd = 28235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00083260 File Offset: 0x00081460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLevelLoadedCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00083294 File Offset: 0x00081494
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 28248, RefRangeEnd = 28251, XrefRangeStart = 28235, XrefRangeEnd = 28248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDetectionInternal(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredCheatingDetector.NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000832D8 File Offset: 0x000814D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28251, XrefRangeEnd = 28252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartDetectionAutomatically()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObscuredCheatingDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00083314 File Offset: 0x00081514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28252, XrefRangeEnd = 28275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DisposeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObscuredCheatingDetector.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0000A548 File Offset: 0x00008748
		public ObscuredCheatingDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00083350 File Offset: 0x00081550
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0000A551 File Offset: 0x00008751
		public unsafe static string ComponentName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredCheatingDetector.NativeFieldInfoPtr_ComponentName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredCheatingDetector.NativeFieldInfoPtr_ComponentName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x00083370 File Offset: 0x00081570
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0000A563 File Offset: 0x00008763
		public unsafe static string FinalLogPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredCheatingDetector.NativeFieldInfoPtr_FinalLogPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredCheatingDetector.NativeFieldInfoPtr_FinalLogPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x00083390 File Offset: 0x00081590
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0000A575 File Offset: 0x00008775
		public unsafe static int instancesInScene
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredCheatingDetector.NativeFieldInfoPtr_instancesInScene, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredCheatingDetector.NativeFieldInfoPtr_instancesInScene, (void*)(&value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000833AC File Offset: 0x000815AC
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0000A583 File Offset: 0x00008783
		public unsafe double doubleEpsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_doubleEpsilon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_doubleEpsilon)) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x000833D4 File Offset: 0x000815D4
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0000A59E File Offset: 0x0000879E
		public unsafe float floatEpsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_floatEpsilon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_floatEpsilon)) = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x000833FC File Offset: 0x000815FC
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0000A5B9 File Offset: 0x000087B9
		public unsafe float vector2Epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_vector2Epsilon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_vector2Epsilon)) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00083424 File Offset: 0x00081624
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0000A5D4 File Offset: 0x000087D4
		public unsafe float vector3Epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_vector3Epsilon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_vector3Epsilon)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0008344C File Offset: 0x0008164C
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0000A5EF File Offset: 0x000087EF
		public unsafe float quaternionEpsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_quaternionEpsilon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredCheatingDetector.NativeFieldInfoPtr_quaternionEpsilon)) = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00083474 File Offset: 0x00081674
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0000A60A File Offset: 0x0000880A
		public unsafe static ObscuredCheatingDetector _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredCheatingDetector.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObscuredCheatingDetector>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredCheatingDetector.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeFieldInfoPtr_ComponentName;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeFieldInfoPtr_FinalLogPrefix;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeFieldInfoPtr_instancesInScene;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeFieldInfoPtr_doubleEpsilon;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeFieldInfoPtr_floatEpsilon;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeFieldInfoPtr_vector2Epsilon;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeFieldInfoPtr_vector3Epsilon;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeFieldInfoPtr_quaternionEpsilon;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_ObscuredCheatingDetector_0;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_0;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeMethodInfoPtr_StopDetection_Public_Static_Void_0;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ObscuredCheatingDetector_0;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ObscuredCheatingDetector_0;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_ObscuredCheatingDetector_0;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeMethodInfoPtr_get_ExistsAndIsRunning_Internal_Static_get_Boolean_0;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0;
	}
}
