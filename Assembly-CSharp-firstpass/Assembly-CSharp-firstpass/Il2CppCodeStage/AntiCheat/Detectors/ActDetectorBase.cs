using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppCodeStage.AntiCheat.Detectors
{
	// Token: 0x0200020B RID: 523
	public class ActDetectorBase : MonoBehaviour
	{
		// Token: 0x06001CA5 RID: 7333 RVA: 0x0008227C File Offset: 0x0008047C
		// Note: this type is marked as 'beforefieldinit'.
		static ActDetectorBase()
		{
			Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Detectors", "ActDetectorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr);
			ActDetectorBase.NativeFieldInfoPtr_ContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "ContainerName");
			ActDetectorBase.NativeFieldInfoPtr_MenuPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "MenuPath");
			ActDetectorBase.NativeFieldInfoPtr_GameObjectMenuPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "GameObjectMenuPath");
			ActDetectorBase.NativeFieldInfoPtr_detectorsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "detectorsContainer");
			ActDetectorBase.NativeFieldInfoPtr_autoStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "autoStart");
			ActDetectorBase.NativeFieldInfoPtr_keepAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "keepAlive");
			ActDetectorBase.NativeFieldInfoPtr_autoDispose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "autoDispose");
			ActDetectorBase.NativeFieldInfoPtr_CheatDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "CheatDetected");
			ActDetectorBase.NativeFieldInfoPtr_detectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "detectionEvent");
			ActDetectorBase.NativeFieldInfoPtr_detectionEventHasListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "detectionEventHasListener");
			ActDetectorBase.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "started");
			ActDetectorBase.NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, "isRunning");
			ActDetectorBase.NativeMethodInfoPtr_add_CheatDetected_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667985);
			ActDetectorBase.NativeMethodInfoPtr_remove_CheatDetected_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667986);
			ActDetectorBase.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667987);
			ActDetectorBase.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667988);
			ActDetectorBase.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667989);
			ActDetectorBase.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667990);
			ActDetectorBase.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667991);
			ActDetectorBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667992);
			ActDetectorBase.NativeMethodInfoPtr_OnCheatingDetected_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667993);
			ActDetectorBase.NativeMethodInfoPtr_Init_Protected_Virtual_New_Boolean_ActDetectorBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667994);
			ActDetectorBase.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667995);
			ActDetectorBase.NativeMethodInfoPtr_DetectorHasCallbacks_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667996);
			ActDetectorBase.NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667997);
			ActDetectorBase.NativeMethodInfoPtr_PauseDetector_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667998);
			ActDetectorBase.NativeMethodInfoPtr_ResumeDetector_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100667999);
			ActDetectorBase.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100668000);
			ActDetectorBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr, 100668001);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000824F0 File Offset: 0x000806F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 27788, RefRangeEnd = 27792, XrefRangeStart = 27785, XrefRangeEnd = 27788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CheatDetected(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActDetectorBase.NativeMethodInfoPtr_add_CheatDetected_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00082534 File Offset: 0x00080734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27792, XrefRangeEnd = 27795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CheatDetected(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActDetectorBase.NativeMethodInfoPtr_remove_CheatDetected_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00082578 File Offset: 0x00080778
		public unsafe bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActDetectorBase.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000825B4 File Offset: 0x000807B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27795, XrefRangeEnd = 27818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActDetectorBase.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000825E8 File Offset: 0x000807E8
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActDetectorBase.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0008261C File Offset: 0x0008081C
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActDetectorBase.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00082650 File Offset: 0x00080850
		[CallerCount(0)]
		public unsafe void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActDetectorBase.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00082684 File Offset: 0x00080884
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 27837, RefRangeEnd = 27841, XrefRangeStart = 27818, XrefRangeEnd = 27837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x000826C0 File Offset: 0x000808C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27841, XrefRangeEnd = 27844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCheatingDetected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_OnCheatingDetected_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000826FC File Offset: 0x000808FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27844, XrefRangeEnd = 27883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(detectorName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_Init_Protected_Virtual_New_Boolean_ActDetectorBase_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00082768 File Offset: 0x00080968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27883, XrefRangeEnd = 27887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DisposeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000827A4 File Offset: 0x000809A4
		[CallerCount(0)]
		public unsafe virtual bool DetectorHasCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_DetectorHasCallbacks_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000827EC File Offset: 0x000809EC
		[CallerCount(0)]
		public unsafe virtual void StopDetectionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00082828 File Offset: 0x00080A28
		[CallerCount(0)]
		public unsafe virtual void PauseDetector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_PauseDetector_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00082864 File Offset: 0x00080A64
		[CallerCount(0)]
		public unsafe virtual bool ResumeDetector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_ResumeDetector_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000828AC File Offset: 0x00080AAC
		[CallerCount(0)]
		public unsafe virtual void StartDetectionAutomatically()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActDetectorBase.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000828E8 File Offset: 0x00080AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27887, XrefRangeEnd = 27890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActDetectorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActDetectorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActDetectorBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0000A3EA File Offset: 0x000085EA
		public ActDetectorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00082924 File Offset: 0x00080B24
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x0000A3F3 File Offset: 0x000085F3
		public unsafe static string ContainerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActDetectorBase.NativeFieldInfoPtr_ContainerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActDetectorBase.NativeFieldInfoPtr_ContainerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00082944 File Offset: 0x00080B44
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x0000A405 File Offset: 0x00008605
		public unsafe static string MenuPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActDetectorBase.NativeFieldInfoPtr_MenuPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActDetectorBase.NativeFieldInfoPtr_MenuPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00082964 File Offset: 0x00080B64
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x0000A417 File Offset: 0x00008617
		public unsafe static string GameObjectMenuPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActDetectorBase.NativeFieldInfoPtr_GameObjectMenuPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActDetectorBase.NativeFieldInfoPtr_GameObjectMenuPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00082984 File Offset: 0x00080B84
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x0000A429 File Offset: 0x00008629
		public unsafe static GameObject detectorsContainer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActDetectorBase.NativeFieldInfoPtr_detectorsContainer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActDetectorBase.NativeFieldInfoPtr_detectorsContainer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x000829AC File Offset: 0x00080BAC
		// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x0000A43B File Offset: 0x0000863B
		public unsafe bool autoStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_autoStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_autoStart)) = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x000829D4 File Offset: 0x00080BD4
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x0000A456 File Offset: 0x00008656
		public unsafe bool keepAlive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_keepAlive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_keepAlive)) = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x000829FC File Offset: 0x00080BFC
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0000A471 File Offset: 0x00008671
		public unsafe bool autoDispose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_autoDispose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_autoDispose)) = value;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00082A24 File Offset: 0x00080C24
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0000A48C File Offset: 0x0000868C
		public unsafe Action CheatDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_CheatDetected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_CheatDetected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00082A54 File Offset: 0x00080C54
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0000A4AB File Offset: 0x000086AB
		public unsafe UnityEvent detectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_detectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_detectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00082A84 File Offset: 0x00080C84
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0000A4CA File Offset: 0x000086CA
		public unsafe bool detectionEventHasListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_detectionEventHasListener);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_detectionEventHasListener)) = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x00082AAC File Offset: 0x00080CAC
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0000A4E5 File Offset: 0x000086E5
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00082AD4 File Offset: 0x00080CD4
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0000A500 File Offset: 0x00008700
		public unsafe bool isRunning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_isRunning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActDetectorBase.NativeFieldInfoPtr_isRunning)) = value;
			}
		}

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeFieldInfoPtr_ContainerName;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeFieldInfoPtr_MenuPath;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeFieldInfoPtr_GameObjectMenuPath;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeFieldInfoPtr_detectorsContainer;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeFieldInfoPtr_autoStart;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeFieldInfoPtr_keepAlive;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeFieldInfoPtr_autoDispose;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeFieldInfoPtr_CheatDetected;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeFieldInfoPtr_detectionEvent;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeFieldInfoPtr_detectionEventHasListener;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeFieldInfoPtr_isRunning;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeMethodInfoPtr_add_CheatDetected_Public_add_Void_Action_0;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeMethodInfoPtr_remove_CheatDetected_Public_rem_Void_Action_0;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr_OnCheatingDetected_Internal_Virtual_New_Void_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_New_Boolean_ActDetectorBase_String_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_New_Void_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_DetectorHasCallbacks_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_New_Void_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_PauseDetector_Protected_Virtual_New_Void_0;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeMethodInfoPtr_ResumeDetector_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
