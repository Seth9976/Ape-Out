using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B5 RID: 1205
	[Serializable]
	public sealed class ConditionalAttribute : Attribute
	{
		// Token: 0x060048AE RID: 18606 RVA: 0x001514E4 File Offset: 0x0014F6E4
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalAttribute()
		{
			Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "ConditionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr);
			ConditionalAttribute.NativeFieldInfoPtr_m_conditionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr, "m_conditionString");
			ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr, 100674199);
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x0015153C File Offset: 0x0014F73C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalAttribute(string conditionString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(conditionString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x0001B194 File Offset: 0x00019394
		public ConditionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x00151588 File Offset: 0x0014F788
		// (set) Token: 0x060048B2 RID: 18610 RVA: 0x0001B19D File Offset: 0x0001939D
		public unsafe string m_conditionString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalAttribute.NativeFieldInfoPtr_m_conditionString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalAttribute.NativeFieldInfoPtr_m_conditionString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003AF7 RID: 15095
		private static readonly IntPtr NativeFieldInfoPtr_m_conditionString;

		// Token: 0x04003AF8 RID: 15096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
