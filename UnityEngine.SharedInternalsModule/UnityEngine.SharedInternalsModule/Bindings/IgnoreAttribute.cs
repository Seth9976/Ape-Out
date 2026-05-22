using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001A RID: 26
	public class IgnoreAttribute : Attribute
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00004370 File Offset: 0x00002570
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoreAttribute()
		{
			Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "IgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr);
			IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, "<DoesNotContributeToSize>k__BackingField");
			IgnoreAttribute.NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, 100663353);
			IgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, 100663354);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000265E File Offset: 0x0000085E
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000043DC File Offset: 0x000025DC
		public unsafe bool DoesNotContributeToSize
		{
			get
			{
				return this._DoesNotContributeToSize_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreAttribute.NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000441C File Offset: 0x0000261C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IgnoreAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000263A File Offset: 0x0000083A
		public IgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004458 File Offset: 0x00002658
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002643 File Offset: 0x00000843
		public unsafe bool _DoesNotContributeToSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField)) = value;
			}
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
