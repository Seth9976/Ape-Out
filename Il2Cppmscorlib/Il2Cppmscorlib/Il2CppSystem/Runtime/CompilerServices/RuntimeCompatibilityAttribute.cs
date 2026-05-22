using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041F RID: 1055
	[Serializable]
	public sealed class RuntimeCompatibilityAttribute : Attribute
	{
		// Token: 0x060042E8 RID: 17128 RVA: 0x0013691C File Offset: 0x00134B1C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeCompatibilityAttribute()
		{
			Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeCompatibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr);
			RuntimeCompatibilityAttribute.NativeFieldInfoPtr_m_wrapNonExceptionThrows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, "m_wrapNonExceptionThrows");
			RuntimeCompatibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, 100673086);
			RuntimeCompatibilityAttribute.NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, 100673087);
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x00136988 File Offset: 0x00134B88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeCompatibilityAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeCompatibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001121 RID: 4385
		// (set) Token: 0x060042EA RID: 17130 RVA: 0x001369C4 File Offset: 0x00134BC4
		public unsafe bool WrapNonExceptionThrows
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeCompatibilityAttribute.NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x00019523 File Offset: 0x00017723
		public RuntimeCompatibilityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x00136A04 File Offset: 0x00134C04
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x0001952C File Offset: 0x0001772C
		public unsafe bool m_wrapNonExceptionThrows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeCompatibilityAttribute.NativeFieldInfoPtr_m_wrapNonExceptionThrows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeCompatibilityAttribute.NativeFieldInfoPtr_m_wrapNonExceptionThrows)) = value;
			}
		}

		// Token: 0x0400367C RID: 13948
		private static readonly IntPtr NativeFieldInfoPtr_m_wrapNonExceptionThrows;

		// Token: 0x0400367D RID: 13949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400367E RID: 13950
		private static readonly IntPtr NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0;
	}
}
