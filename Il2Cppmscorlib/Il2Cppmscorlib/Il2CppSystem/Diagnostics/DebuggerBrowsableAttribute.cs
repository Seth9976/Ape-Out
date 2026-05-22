using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BB RID: 1211
	public sealed class DebuggerBrowsableAttribute : Attribute
	{
		// Token: 0x060048C1 RID: 18625 RVA: 0x0015172C File Offset: 0x0014F92C
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerBrowsableAttribute()
		{
			Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerBrowsableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr);
			DebuggerBrowsableAttribute.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr, "state");
			DebuggerBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr, 100674204);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00151784 File Offset: 0x0014F984
		[CallerCount(0)]
		public unsafe DebuggerBrowsableAttribute(DebuggerBrowsableState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x0001B2A6 File Offset: 0x000194A6
		public DebuggerBrowsableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060048C4 RID: 18628 RVA: 0x001517CC File Offset: 0x0014F9CC
		// (set) Token: 0x060048C5 RID: 18629 RVA: 0x0001B2AF File Offset: 0x000194AF
		public unsafe DebuggerBrowsableState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerBrowsableAttribute.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerBrowsableAttribute.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x04003B02 RID: 15106
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04003B03 RID: 15107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0;
	}
}
