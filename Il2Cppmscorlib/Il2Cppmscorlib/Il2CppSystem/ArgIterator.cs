using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200010D RID: 269
	[StructLayout(2)]
	public struct ArgIterator
	{
		// Token: 0x06001412 RID: 5138 RVA: 0x00080788 File Offset: 0x0007E988
		// Note: this type is marked as 'beforefieldinit'.
		static ArgIterator()
		{
			Il2CppClassPointerStore<ArgIterator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgIterator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr);
			ArgIterator.NativeFieldInfoPtr_sig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "sig");
			ArgIterator.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "args");
			ArgIterator.NativeFieldInfoPtr_next_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "next_arg");
			ArgIterator.NativeFieldInfoPtr_num_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "num_args");
			ArgIterator.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, 100666794);
			ArgIterator.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, 100666795);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00080830 File Offset: 0x0007EA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174487, XrefRangeEnd = 174494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgIterator.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00080874 File Offset: 0x0007EA74
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgIterator.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00006E70 File Offset: 0x00005070
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, ref this));
		}

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeFieldInfoPtr_sig;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeFieldInfoPtr_next_arg;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeFieldInfoPtr_num_args;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400114B RID: 4427
		[FieldOffset(0)]
		public IntPtr sig;

		// Token: 0x0400114C RID: 4428
		[FieldOffset(8)]
		public IntPtr args;

		// Token: 0x0400114D RID: 4429
		[FieldOffset(16)]
		public int next_arg;

		// Token: 0x0400114E RID: 4430
		[FieldOffset(20)]
		public int num_args;
	}
}
