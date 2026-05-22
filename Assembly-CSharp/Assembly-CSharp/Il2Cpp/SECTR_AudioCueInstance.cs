using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000037 RID: 55
	public sealed class SECTR_AudioCueInstance : ValueType
	{
		// Token: 0x06000927 RID: 2343 RVA: 0x0004EED4 File Offset: 0x0004D0D4
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioCueInstance()
		{
			Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioCueInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr);
			SECTR_AudioCueInstance.NativeFieldInfoPtr_internalInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, "internalInstance");
			SECTR_AudioCueInstance.NativeFieldInfoPtr_generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, "generation");
			SECTR_AudioCueInstance.NativeMethodInfoPtr__ctor_Public_Void_SECTR_IAudioInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663978);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Generation_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663979);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Active_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663980);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663981);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663982);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_LocalPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663983);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_set_LocalPosition_Public_Virtual_Final_New_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663984);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Volume_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663985);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Volume_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663986);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Pitch_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663987);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Pitch_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663988);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Mute_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663989);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Mute_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663990);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Pause_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663991);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Pause_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663992);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_TimeSeconds_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663993);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_set_TimeSeconds_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663994);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_get_TimeSamples_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663995);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_set_TimeSamples_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663996);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663997);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_ForceInfinite_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663998);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_ForceOcclusion_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100663999);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_SetParameter_Public_Virtual_Final_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100664000);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_GetInternalAudioSource_Public_Virtual_Final_New_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100664001);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_GetInternalInstance_Public_SECTR_IAudioInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100664002);
			SECTR_AudioCueInstance.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_SECTR_AudioCueInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, 100664003);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0004F134 File Offset: 0x0004D334
		[CallerCount(0)]
		public unsafe SECTR_AudioCueInstance(SECTR_IAudioInstance internalInstance, int generation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalInstance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr__ctor_Public_Void_SECTR_IAudioInstance_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0004F194 File Offset: 0x0004D394
		public unsafe int Generation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Generation_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0004F1D8 File Offset: 0x0004D3D8
		public unsafe bool Active
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 37288, RefRangeEnd = 37327, XrefRangeStart = 37283, XrefRangeEnd = 37288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Active_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0004F21C File Offset: 0x0004D41C
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x0004F260 File Offset: 0x0004D460
		public unsafe Vector3 Position
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37334, RefRangeEnd = 37336, XrefRangeStart = 37327, XrefRangeEnd = 37334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37336, XrefRangeEnd = 37340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0004F2A4 File Offset: 0x0004D4A4
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0004F2E8 File Offset: 0x0004D4E8
		public unsafe Vector3 LocalPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37340, XrefRangeEnd = 37347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_LocalPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37347, XrefRangeEnd = 37351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_set_LocalPosition_Public_Virtual_Final_New_set_Void_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0004F32C File Offset: 0x0004D52C
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x0004F370 File Offset: 0x0004D570
		public unsafe float Volume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37355, RefRangeEnd = 37356, XrefRangeStart = 37351, XrefRangeEnd = 37355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Volume_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 37360, RefRangeEnd = 37367, XrefRangeStart = 37356, XrefRangeEnd = 37360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Volume_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0004F3B4 File Offset: 0x0004D5B4
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x0004F3F8 File Offset: 0x0004D5F8
		public unsafe float Pitch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37367, XrefRangeEnd = 37371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Pitch_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 37375, RefRangeEnd = 37378, XrefRangeStart = 37371, XrefRangeEnd = 37375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Pitch_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0004F43C File Offset: 0x0004D63C
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x0004F480 File Offset: 0x0004D680
		public unsafe bool Mute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37378, XrefRangeEnd = 37382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Mute_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37382, XrefRangeEnd = 37386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Mute_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0004F4C4 File Offset: 0x0004D6C4
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0004F508 File Offset: 0x0004D708
		public unsafe bool Pause
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37386, XrefRangeEnd = 37390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_Pause_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37390, XrefRangeEnd = 37394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_set_Pause_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0004F54C File Offset: 0x0004D74C
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0004F590 File Offset: 0x0004D790
		public unsafe float TimeSeconds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37394, XrefRangeEnd = 37398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_TimeSeconds_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37402, RefRangeEnd = 37403, XrefRangeStart = 37398, XrefRangeEnd = 37402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_set_TimeSeconds_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0004F5D4 File Offset: 0x0004D7D4
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0004F618 File Offset: 0x0004D818
		public unsafe int TimeSamples
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37403, XrefRangeEnd = 37407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_get_TimeSamples_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37407, XrefRangeEnd = 37411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_set_TimeSamples_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0004F65C File Offset: 0x0004D85C
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 37415, RefRangeEnd = 37443, XrefRangeStart = 37411, XrefRangeEnd = 37415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool stopImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopImmediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0004F6A0 File Offset: 0x0004D8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37443, XrefRangeEnd = 37447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceInfinite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_ForceInfinite_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0004F6D8 File Offset: 0x0004D8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37447, XrefRangeEnd = 37451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceOcclusion(bool occluded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref occluded;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_ForceOcclusion_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0004F71C File Offset: 0x0004D91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37451, XrefRangeEnd = 37455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParameter(string param, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_SetParameter_Public_Virtual_Final_New_Void_String_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0004F774 File Offset: 0x0004D974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37459, RefRangeEnd = 37460, XrefRangeStart = 37455, XrefRangeEnd = 37459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSource GetInternalAudioSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_GetInternalAudioSource_Public_Virtual_Final_New_AudioSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0004F7B8 File Offset: 0x0004D9B8
		[CallerCount(0)]
		public unsafe SECTR_IAudioInstance GetInternalInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_GetInternalInstance_Public_SECTR_IAudioInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_IAudioInstance>(intPtr3) : null;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0004F7FC File Offset: 0x0004D9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37460, XrefRangeEnd = 37461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(SECTR_AudioCueInstance x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCueInstance.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_SECTR_AudioCueInstance_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00007F85 File Offset: 0x00006185
		public SECTR_AudioCueInstance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00007F8E File Offset: 0x0000618E
		public SECTR_AudioCueInstance()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr))
		{
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0004F844 File Offset: 0x0004DA44
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00007FA0 File Offset: 0x000061A0
		public unsafe SECTR_IAudioInstance internalInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCueInstance.NativeFieldInfoPtr_internalInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_IAudioInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCueInstance.NativeFieldInfoPtr_internalInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0004F874 File Offset: 0x0004DA74
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00007FBF File Offset: 0x000061BF
		public unsafe int generation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCueInstance.NativeFieldInfoPtr_generation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCueInstance.NativeFieldInfoPtr_generation)) = value;
			}
		}

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_internalInstance;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_generation;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SECTR_IAudioInstance_Int32_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_get_Generation_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector3_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPosition_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPosition_Public_Virtual_Final_New_set_Void_Vector3_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_get_Pitch_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_set_Pitch_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_get_Mute_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_set_Mute_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_get_Pause_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_set_Pause_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSeconds_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSeconds_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSamples_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSamples_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_ForceInfinite_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_ForceOcclusion_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_SetParameter_Public_Virtual_Final_New_Void_String_Single_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalAudioSource_Public_Virtual_Final_New_AudioSource_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalInstance_Public_SECTR_IAudioInstance_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_SECTR_AudioCueInstance_0;
	}
}
