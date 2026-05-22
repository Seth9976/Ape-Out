using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000006 RID: 6
	public class BurstCompatibleAttribute : Attribute
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003F04 File Offset: 0x00002104
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompatibleAttribute()
		{
			Il2CppClassPointerStore<BurstCompatibleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "BurstCompatibleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompatibleAttribute>.NativeClassPtr);
			BurstCompatibleAttribute.NativeFieldInfoPtr__GenericTypeArguments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompatibleAttribute>.NativeClassPtr, "<GenericTypeArguments>k__BackingField");
			BurstCompatibleAttribute.NativeMethodInfoPtr_set_GenericTypeArguments_Public_set_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompatibleAttribute>.NativeClassPtr, 100663375);
			BurstCompatibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompatibleAttribute>.NativeClassPtr, 100663376);
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00003F70 File Offset: 0x00002170
		public unsafe Il2CppReferenceArray<Type> GenericTypeArguments
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompatibleAttribute.NativeMethodInfoPtr_set_GenericTypeArguments_Public_set_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003FB4 File Offset: 0x000021B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompatibleAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompatibleAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompatibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002173 File Offset: 0x00000373
		public BurstCompatibleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003FF0 File Offset: 0x000021F0
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000217C File Offset: 0x0000037C
		public unsafe Il2CppReferenceArray<Type> _GenericTypeArguments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompatibleAttribute.NativeFieldInfoPtr__GenericTypeArguments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompatibleAttribute.NativeFieldInfoPtr__GenericTypeArguments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr__GenericTypeArguments_k__BackingField;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_GenericTypeArguments_Public_set_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
