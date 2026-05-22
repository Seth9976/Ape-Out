using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000057 RID: 87
	public class ITupleInternal : Il2CppObjectBase
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x00003EFF File Offset: 0x000020FF
		// Note: this type is marked as 'beforefieldinit'.
		static ITupleInternal()
		{
			Il2CppClassPointerStore<ITupleInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ITupleInternal");
			ITupleInternal.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITupleInternal>.NativeClassPtr, 100664270);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0003D168 File Offset: 0x0003B368
		[CallerCount(0)]
		public unsafe virtual string ToString(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITupleInternal.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00003F2E File Offset: 0x0000212E
		public ITupleInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0;
	}
}
