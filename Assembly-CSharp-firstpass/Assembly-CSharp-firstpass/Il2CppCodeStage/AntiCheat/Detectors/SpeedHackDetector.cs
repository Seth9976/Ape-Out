using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace Il2CppCodeStage.AntiCheat.Detectors
{
	// Token: 0x0200020E RID: 526
	public class SpeedHackDetector : ActDetectorBase
	{
		// Token: 0x06001D02 RID: 7426 RVA: 0x0008349C File Offset: 0x0008169C
		// Note: this type is marked as 'beforefieldinit'.
		static SpeedHackDetector()
		{
			Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Detectors", "SpeedHackDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr);
			SpeedHackDetector.NativeFieldInfoPtr_ComponentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "ComponentName");
			SpeedHackDetector.NativeFieldInfoPtr_LogPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "LogPrefix");
			SpeedHackDetector.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "TicksPerSecond");
			SpeedHackDetector.NativeFieldInfoPtr_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "Threshold");
			SpeedHackDetector.NativeFieldInfoPtr_ThresholdFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "ThresholdFloat");
			SpeedHackDetector.NativeFieldInfoPtr_instancesInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "instancesInScene");
			SpeedHackDetector.NativeFieldInfoPtr_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "interval");
			SpeedHackDetector.NativeFieldInfoPtr_maxFalsePositives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "maxFalsePositives");
			SpeedHackDetector.NativeFieldInfoPtr_coolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "coolDown");
			SpeedHackDetector.NativeFieldInfoPtr_currentFalsePositives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "currentFalsePositives");
			SpeedHackDetector.NativeFieldInfoPtr_currentCooldownShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "currentCooldownShots");
			SpeedHackDetector.NativeFieldInfoPtr_ticksOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "ticksOnStart");
			SpeedHackDetector.NativeFieldInfoPtr_vulnerableTicksOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "vulnerableTicksOnStart");
			SpeedHackDetector.NativeFieldInfoPtr_previousTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "previousTicks");
			SpeedHackDetector.NativeFieldInfoPtr_previousIntervalTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "previousIntervalTicks");
			SpeedHackDetector.NativeFieldInfoPtr_vulnerableTimeOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "vulnerableTimeOnStart");
			SpeedHackDetector.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, "<Instance>k__BackingField");
			SpeedHackDetector.NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_SpeedHackDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668026);
			SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668027);
			SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668028);
			SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668029);
			SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668030);
			SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668031);
			SpeedHackDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668032);
			SpeedHackDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668033);
			SpeedHackDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_SpeedHackDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668034);
			SpeedHackDetector.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_SpeedHackDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668035);
			SpeedHackDetector.NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_SpeedHackDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668036);
			SpeedHackDetector.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668037);
			SpeedHackDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668038);
			SpeedHackDetector.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668039);
			SpeedHackDetector.NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668040);
			SpeedHackDetector.NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668041);
			SpeedHackDetector.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668042);
			SpeedHackDetector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668043);
			SpeedHackDetector.NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_Single_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668044);
			SpeedHackDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668045);
			SpeedHackDetector.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668046);
			SpeedHackDetector.NativeMethodInfoPtr_ResetStartTicks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668047);
			SpeedHackDetector.NativeMethodInfoPtr_GetReliableTicks_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr, 100668048);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000837EC File Offset: 0x000819EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28275, XrefRangeEnd = 28276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpeedHackDetector AddToSceneOrGetExisting()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_SpeedHackDetector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpeedHackDetector>(intPtr3) : null;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00083820 File Offset: 0x00081A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28276, XrefRangeEnd = 28301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00083848 File Offset: 0x00081A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28301, XrefRangeEnd = 28306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00083880 File Offset: 0x00081A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28306, XrefRangeEnd = 28310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action callback, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000838C4 File Offset: 0x00081AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28310, XrefRangeEnd = 28313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action callback, float interval, byte maxFalsePositives)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFalsePositives;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00083918 File Offset: 0x00081B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28313, XrefRangeEnd = 28315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action callback, float interval, byte maxFalsePositives, int coolDown)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFalsePositives;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coolDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00083978 File Offset: 0x00081B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28315, XrefRangeEnd = 28331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000839A0 File Offset: 0x00081BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28331, XrefRangeEnd = 28347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x000839C8 File Offset: 0x00081BC8
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x000839FC File Offset: 0x00081BFC
		public unsafe static SpeedHackDetector Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28347, XrefRangeEnd = 28349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_SpeedHackDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpeedHackDetector>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28349, XrefRangeEnd = 28351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_SpeedHackDetector_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x00083A34 File Offset: 0x00081C34
		public unsafe static SpeedHackDetector GetOrCreateInstance
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 28394, RefRangeEnd = 28405, XrefRangeStart = 28351, XrefRangeEnd = 28394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_SpeedHackDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpeedHackDetector>(intPtr3) : null;
			}
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00083A68 File Offset: 0x00081C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28405, XrefRangeEnd = 28408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpeedHackDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedHackDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00083AA4 File Offset: 0x00081CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28408, XrefRangeEnd = 28425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00083AD8 File Offset: 0x00081CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28425, XrefRangeEnd = 28428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedHackDetector.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00083B14 File Offset: 0x00081D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28428, XrefRangeEnd = 28445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00083B60 File Offset: 0x00081D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLevelLoadedCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00083B94 File Offset: 0x00081D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28445, XrefRangeEnd = 28446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationPause(bool pause)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pause;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00083BD4 File Offset: 0x00081DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28446, XrefRangeEnd = 28455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00083C08 File Offset: 0x00081E08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 28484, RefRangeEnd = 28490, XrefRangeStart = 28455, XrefRangeEnd = 28484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDetectionInternal(Action callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkInterval;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref falsePositives;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shotsTillCooldown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_Single_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00083C74 File Offset: 0x00081E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28490, XrefRangeEnd = 28491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartDetectionAutomatically()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedHackDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00083CB0 File Offset: 0x00081EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28491, XrefRangeEnd = 28514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DisposeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedHackDetector.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00083CEC File Offset: 0x00081EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28520, RefRangeEnd = 28522, XrefRangeStart = 28514, XrefRangeEnd = 28520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetStartTicks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_ResetStartTicks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00083D20 File Offset: 0x00081F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28522, XrefRangeEnd = 28526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetReliableTicks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedHackDetector.NativeMethodInfoPtr_GetReliableTicks_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0000A61C File Offset: 0x0000881C
		public SpeedHackDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00083D5C File Offset: 0x00081F5C
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0000A625 File Offset: 0x00008825
		public unsafe static string ComponentName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpeedHackDetector.NativeFieldInfoPtr_ComponentName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedHackDetector.NativeFieldInfoPtr_ComponentName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00083D7C File Offset: 0x00081F7C
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0000A637 File Offset: 0x00008837
		public unsafe static string LogPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpeedHackDetector.NativeFieldInfoPtr_LogPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedHackDetector.NativeFieldInfoPtr_LogPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00083D9C File Offset: 0x00081F9C
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000A649 File Offset: 0x00008849
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SpeedHackDetector.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedHackDetector.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x00083DB8 File Offset: 0x00081FB8
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0000A657 File Offset: 0x00008857
		public unsafe static int Threshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SpeedHackDetector.NativeFieldInfoPtr_Threshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedHackDetector.NativeFieldInfoPtr_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00083DD4 File Offset: 0x00081FD4
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000A665 File Offset: 0x00008865
		public unsafe static float ThresholdFloat
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SpeedHackDetector.NativeFieldInfoPtr_ThresholdFloat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedHackDetector.NativeFieldInfoPtr_ThresholdFloat, (void*)(&value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00083DF0 File Offset: 0x00081FF0
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000A673 File Offset: 0x00008873
		public unsafe static int instancesInScene
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SpeedHackDetector.NativeFieldInfoPtr_instancesInScene, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedHackDetector.NativeFieldInfoPtr_instancesInScene, (void*)(&value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00083E0C File Offset: 0x0008200C
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000A681 File Offset: 0x00008881
		public unsafe float interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_interval)) = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00083E34 File Offset: 0x00082034
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000A69C File Offset: 0x0000889C
		public unsafe byte maxFalsePositives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_maxFalsePositives);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_maxFalsePositives)) = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00083E5C File Offset: 0x0008205C
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000A6B7 File Offset: 0x000088B7
		public unsafe int coolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_coolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_coolDown)) = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00083E84 File Offset: 0x00082084
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000A6D2 File Offset: 0x000088D2
		public unsafe byte currentFalsePositives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_currentFalsePositives);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_currentFalsePositives)) = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00083EAC File Offset: 0x000820AC
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000A6ED File Offset: 0x000088ED
		public unsafe int currentCooldownShots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_currentCooldownShots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_currentCooldownShots)) = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00083ED4 File Offset: 0x000820D4
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0000A708 File Offset: 0x00008908
		public unsafe long ticksOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_ticksOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_ticksOnStart)) = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00083EFC File Offset: 0x000820FC
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0000A723 File Offset: 0x00008923
		public unsafe long vulnerableTicksOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_vulnerableTicksOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_vulnerableTicksOnStart)) = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00083F24 File Offset: 0x00082124
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000A73E File Offset: 0x0000893E
		public unsafe long previousTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_previousTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_previousTicks)) = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00083F4C File Offset: 0x0008214C
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0000A759 File Offset: 0x00008959
		public unsafe long previousIntervalTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_previousIntervalTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_previousIntervalTicks)) = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00083F74 File Offset: 0x00082174
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0000A774 File Offset: 0x00008974
		public unsafe float vulnerableTimeOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_vulnerableTimeOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedHackDetector.NativeFieldInfoPtr_vulnerableTimeOnStart)) = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00083F9C File Offset: 0x0008219C
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0000A78F File Offset: 0x0000898F
		public unsafe static SpeedHackDetector _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpeedHackDetector.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpeedHackDetector>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedHackDetector.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeFieldInfoPtr_ComponentName;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeFieldInfoPtr_LogPrefix;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeFieldInfoPtr_Threshold;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeFieldInfoPtr_ThresholdFloat;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeFieldInfoPtr_instancesInScene;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeFieldInfoPtr_interval;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeFieldInfoPtr_maxFalsePositives;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeFieldInfoPtr_coolDown;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeFieldInfoPtr_currentFalsePositives;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeFieldInfoPtr_currentCooldownShots;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeFieldInfoPtr_ticksOnStart;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeFieldInfoPtr_vulnerableTicksOnStart;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeFieldInfoPtr_previousTicks;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeFieldInfoPtr_previousIntervalTicks;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeFieldInfoPtr_vulnerableTimeOnStart;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_SpeedHackDetector_0;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_0;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_0;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_Byte_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Single_Byte_Int32_0;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeMethodInfoPtr_StopDetection_Public_Static_Void_0;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SpeedHackDetector_0;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_SpeedHackDetector_0;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_SpeedHackDetector_0;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_Single_Byte_Int32_0;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeMethodInfoPtr_ResetStartTicks_Private_Void_0;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeMethodInfoPtr_GetReliableTicks_Private_Int64_0;
	}
}
