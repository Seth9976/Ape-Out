using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BC RID: 1212
	public sealed class DebuggerTypeProxyAttribute : Attribute
	{
		// Token: 0x060048C6 RID: 18630 RVA: 0x001517F4 File Offset: 0x0014F9F4
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerTypeProxyAttribute()
		{
			Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerTypeProxyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr);
			DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr, "typeName");
			DebuggerTypeProxyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr, 100674205);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x0015184C File Offset: 0x0014FA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233211, XrefRangeEnd = 233214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerTypeProxyAttribute(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerTypeProxyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x0001B2CA File Offset: 0x000194CA
		public DebuggerTypeProxyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060048C9 RID: 18633 RVA: 0x00151898 File Offset: 0x0014FA98
		// (set) Token: 0x060048CA RID: 18634 RVA: 0x0001B2D3 File Offset: 0x000194D3
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B04 RID: 15108
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04003B05 RID: 15109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
