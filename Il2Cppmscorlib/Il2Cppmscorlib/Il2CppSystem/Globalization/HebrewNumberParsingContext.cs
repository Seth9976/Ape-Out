using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023D RID: 573
	[StructLayout(2)]
	public struct HebrewNumberParsingContext
	{
		// Token: 0x060026CB RID: 9931 RVA: 0x000D0800 File Offset: 0x000CEA00
		// Note: this type is marked as 'beforefieldinit'.
		static HebrewNumberParsingContext()
		{
			Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HebrewNumberParsingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr);
			HebrewNumberParsingContext.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, "state");
			HebrewNumberParsingContext.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, "result");
			HebrewNumberParsingContext.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, 100669687);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x000D086C File Offset: 0x000CEA6C
		[CallerCount(0)]
		public unsafe HebrewNumberParsingContext(int result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumberParsingContext.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0000D298 File Offset: 0x0000B498
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, ref this));
		}

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400229B RID: 8859
		[FieldOffset(0)]
		public HebrewNumber.HS state;

		// Token: 0x0400229C RID: 8860
		[FieldOffset(4)]
		public int result;
	}
}
