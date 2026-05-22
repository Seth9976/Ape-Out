using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B9 RID: 1209
	public sealed class DebuggableAttribute : Attribute
	{
		// Token: 0x060048BC RID: 18620 RVA: 0x00151664 File Offset: 0x0014F864
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggableAttribute()
		{
			Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr);
			DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr, "m_debuggingModes");
			DebuggableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr, 100674203);
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x001516BC File Offset: 0x0014F8BC
		[CallerCount(0)]
		public unsafe DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref modes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x0001B282 File Offset: 0x00019482
		public DebuggableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060048BF RID: 18623 RVA: 0x00151704 File Offset: 0x0014F904
		// (set) Token: 0x060048C0 RID: 18624 RVA: 0x0001B28B File Offset: 0x0001948B
		public unsafe DebuggableAttribute.DebuggingModes m_debuggingModes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes)) = value;
			}
		}

		// Token: 0x04003AFC RID: 15100
		private static readonly IntPtr NativeFieldInfoPtr_m_debuggingModes;

		// Token: 0x04003AFD RID: 15101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0;

		// Token: 0x02000671 RID: 1649
		[OriginalName("mscorlib.dll", "", "DebuggingModes")]
		[Flags]
		public enum DebuggingModes
		{
			// Token: 0x040046D0 RID: 18128
			None = 0,
			// Token: 0x040046D1 RID: 18129
			Default = 1,
			// Token: 0x040046D2 RID: 18130
			DisableOptimizations = 256,
			// Token: 0x040046D3 RID: 18131
			IgnoreSymbolStoreSequencePoints = 2,
			// Token: 0x040046D4 RID: 18132
			EnableEditAndContinue = 4
		}
	}
}
