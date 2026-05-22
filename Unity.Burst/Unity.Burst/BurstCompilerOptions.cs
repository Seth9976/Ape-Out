using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst
{
	// Token: 0x02000008 RID: 8
	public sealed class BurstCompilerOptions : Object
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002D84 File Offset: 0x00000F84
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompilerOptions()
		{
			Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompilerOptions");
			BurstCompilerOptions.NativeFieldInfoPtr_ForceDisableBurstCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "ForceDisableBurstCompilation");
			BurstCompilerOptions.NativeFieldInfoPtr_ForceBurstCompilationSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "ForceBurstCompilationSynchronously");
			BurstCompilerOptions.NativeFieldInfoPtr_IsSecondaryUnityProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "IsSecondaryUnityProcess");
			BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstCompilation");
			BurstCompilerOptions.NativeFieldInfoPtr__enableBurstSafetyChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstSafetyChecks");
			BurstCompilerOptions.NativeFieldInfoPtr__IsGlobal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "<IsGlobal>k__BackingField");
			BurstCompilerOptions.NativeFieldInfoPtr__OptionsChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "<OptionsChanged>k__BackingField");
			BurstCompilerOptions.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663328);
			BurstCompilerOptions.NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663329);
			BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663330);
			BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663331);
			BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663332);
			BurstCompilerOptions.NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663333);
			BurstCompilerOptions.NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663334);
			BurstCompilerOptions.NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663335);
			BurstCompilerOptions.NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663336);
			BurstCompilerOptions.NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663337);
			BurstCompilerOptions.NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663338);
			BurstCompilerOptions.NativeMethodInfoPtr_MaybePreventChangingOption_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663339);
			BurstCompilerOptions.NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002F3C File Offset: 0x0000113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439593, XrefRangeEnd = 439605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompilerOptions(bool isGlobal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isGlobal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002F84 File Offset: 0x00001184
		public unsafe bool IsGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002FC0 File Offset: 0x000011C0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002FFC File Offset: 0x000011FC
		public unsafe bool EnableBurstCompilation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439605, XrefRangeEnd = 439616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000303C File Offset: 0x0000123C
		public unsafe bool EnableBurstSafetyChecks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439616, XrefRangeEnd = 439617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000307C File Offset: 0x0000127C
		public unsafe Action OptionsChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000030BC File Offset: 0x000012BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439617, XrefRangeEnd = 439631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute, bool isForEagerCompilation = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isForEagerCompilation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			attribute = ((intPtr4 == 0) ? null : new BurstCompileAttribute(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003130 File Offset: 0x00001330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 439674, RefRangeEnd = 439677, XrefRangeStart = 439631, XrefRangeEnd = 439674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BurstCompileAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003174 File Offset: 0x00001374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439677, XrefRangeEnd = 439694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasBurstCompileAttribute(MemberInfo member)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000031B8 File Offset: 0x000013B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439694, XrefRangeEnd = 439695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOptionsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000031EC File Offset: 0x000013EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaybeTriggerRecompilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003220 File Offset: 0x00001420
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaybePreventChangingOption()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_MaybePreventChangingOption_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003254 File Offset: 0x00001454
		[CallerCount(0)]
		public unsafe static bool CheckIsSecondaryUnityProcess()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002188 File Offset: 0x00000388
		public BurstCompilerOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003284 File Offset: 0x00001484
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002191 File Offset: 0x00000391
		public unsafe static bool ForceDisableBurstCompilation
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceDisableBurstCompilation, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceDisableBurstCompilation, (void*)(&value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000032A0 File Offset: 0x000014A0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000219F File Offset: 0x0000039F
		public unsafe static bool ForceBurstCompilationSynchronously
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceBurstCompilationSynchronously, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceBurstCompilationSynchronously, (void*)(&value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000032BC File Offset: 0x000014BC
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000021AD File Offset: 0x000003AD
		public unsafe static bool IsSecondaryUnityProcess
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_IsSecondaryUnityProcess, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_IsSecondaryUnityProcess, (void*)(&value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000032D8 File Offset: 0x000014D8
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021BB File Offset: 0x000003BB
		public unsafe bool _enableBurstCompilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompilation)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003300 File Offset: 0x00001500
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000021D6 File Offset: 0x000003D6
		public unsafe bool _enableBurstSafetyChecks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstSafetyChecks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstSafetyChecks)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003328 File Offset: 0x00001528
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000021F1 File Offset: 0x000003F1
		public unsafe bool _IsGlobal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__IsGlobal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__IsGlobal_k__BackingField)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003350 File Offset: 0x00001550
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000220C File Offset: 0x0000040C
		public unsafe Action _OptionsChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__OptionsChanged_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__OptionsChanged_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_ForceDisableBurstCompilation;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_ForceBurstCompilationSynchronously;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_IsSecondaryUnityProcess;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr__enableBurstCompilation;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__enableBurstSafetyChecks;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr__IsGlobal_k__BackingField;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr__OptionsChanged_k__BackingField;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_Boolean_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_MaybePreventChangingOption_Private_Void_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0;
	}
}
