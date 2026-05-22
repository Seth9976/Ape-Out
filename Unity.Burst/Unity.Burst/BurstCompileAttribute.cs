using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000006 RID: 6
	public class BurstCompileAttribute : Attribute
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002678 File Offset: 0x00000878
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompileAttribute()
		{
			Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompileAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr);
			BurstCompileAttribute.NativeFieldInfoPtr__FloatMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<FloatMode>k__BackingField");
			BurstCompileAttribute.NativeFieldInfoPtr__FloatPrecision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<FloatPrecision>k__BackingField");
			BurstCompileAttribute.NativeFieldInfoPtr__CompileSynchronously_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<CompileSynchronously>k__BackingField");
			BurstCompileAttribute.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<Options>k__BackingField");
			BurstCompileAttribute.NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663299);
			BurstCompileAttribute.NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663300);
			BurstCompileAttribute.NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663301);
			BurstCompileAttribute.NativeMethodInfoPtr_get_Options_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663302);
			BurstCompileAttribute.NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663303);
			BurstCompileAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663304);
			BurstCompileAttribute.NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663305);
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002784 File Offset: 0x00000984
		public unsafe FloatMode FloatMode
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000027C4 File Offset: 0x000009C4
		public unsafe FloatPrecision FloatPrecision
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002804 File Offset: 0x00000A04
		public unsafe bool CompileSynchronously
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002844 File Offset: 0x00000A44
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002884 File Offset: 0x00000A84
		public unsafe Il2CppStringArray Options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_Options_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000028C8 File Offset: 0x00000AC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompileAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002904 File Offset: 0x00000B04
		[CallerCount(0)]
		public unsafe BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPrecision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020D4 File Offset: 0x000002D4
		public BurstCompileAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000295C File Offset: 0x00000B5C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020DD File Offset: 0x000002DD
		public unsafe FloatMode _FloatMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__FloatMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__FloatMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002984 File Offset: 0x00000B84
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000020F8 File Offset: 0x000002F8
		public unsafe FloatPrecision _FloatPrecision_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__FloatPrecision_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__FloatPrecision_k__BackingField)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000029AC File Offset: 0x00000BAC
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002113 File Offset: 0x00000313
		public unsafe bool _CompileSynchronously_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__CompileSynchronously_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__CompileSynchronously_k__BackingField)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000029D4 File Offset: 0x00000BD4
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000212E File Offset: 0x0000032E
		public unsafe Il2CppStringArray _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr__FloatMode_k__BackingField;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr__FloatPrecision_k__BackingField;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr__CompileSynchronously_k__BackingField;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Internal_get_Il2CppStringArray_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0;
	}
}
