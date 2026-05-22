using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000C RID: 12
	public sealed class NativeWritableSelfAttribute : Attribute
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00003214 File Offset: 0x00001414
		// Note: this type is marked as 'beforefieldinit'.
		static NativeWritableSelfAttribute()
		{
			Il2CppClassPointerStore<NativeWritableSelfAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeWritableSelfAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeWritableSelfAttribute>.NativeClassPtr);
			NativeWritableSelfAttribute.NativeFieldInfoPtr__WritableSelf_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeWritableSelfAttribute>.NativeClassPtr, "<WritableSelf>k__BackingField");
			NativeWritableSelfAttribute.NativeMethodInfoPtr_set_WritableSelf_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeWritableSelfAttribute>.NativeClassPtr, 100663317);
			NativeWritableSelfAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeWritableSelfAttribute>.NativeClassPtr, 100663318);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002338 File Offset: 0x00000538
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00003280 File Offset: 0x00001480
		public unsafe bool WritableSelf
		{
			get
			{
				return this._WritableSelf_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeWritableSelfAttribute.NativeMethodInfoPtr_set_WritableSelf_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000032C0 File Offset: 0x000014C0
		[CallerCount(0)]
		public unsafe NativeWritableSelfAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeWritableSelfAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeWritableSelfAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002314 File Offset: 0x00000514
		public NativeWritableSelfAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000032FC File Offset: 0x000014FC
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000231D File Offset: 0x0000051D
		public unsafe bool _WritableSelf_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeWritableSelfAttribute.NativeFieldInfoPtr__WritableSelf_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeWritableSelfAttribute.NativeFieldInfoPtr__WritableSelf_k__BackingField)) = value;
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr__WritableSelf_k__BackingField;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_set_WritableSelf_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
