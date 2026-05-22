using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000036 RID: 54
	[StructLayout(2)]
	public struct sjYknhXhXWcXbHkWlisjfjbNJfSA
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x00022A5C File Offset: 0x00020C5C
		// Note: this type is marked as 'beforefieldinit'.
		static sjYknhXhXWcXbHkWlisjfjbNJfSA()
		{
			Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "sjYknhXhXWcXbHkWlisjfjbNJfSA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr);
			sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeFieldInfoPtr_LDBECukoSmFXfHSyoZTXBOjKgIW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr, "LDBECukoSmFXfHSyoZTXBOjKgIW");
			sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_sjYknhXhXWcXbHkWlisjfjbNJfSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr, 100664549);
			sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr, 100664550);
			sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr, 100664551);
			sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_sjYknhXhXWcXbHkWlisjfjbNJfSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr, 100664552);
			sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr, 100664553);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00022B04 File Offset: 0x00020D04
		[CallerCount(0)]
		public unsafe bool Equals(sjYknhXhXWcXbHkWlisjfjbNJfSA other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_sjYknhXhXWcXbHkWlisjfjbNJfSA_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00022B44 File Offset: 0x00020D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358058, XrefRangeEnd = 358060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00022B88 File Offset: 0x00020D88
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00022BB8 File Offset: 0x00020DB8
		[CallerCount(0)]
		public unsafe static implicit operator bool(sjYknhXhXWcXbHkWlisjfjbNJfSA booleanValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref booleanValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_sjYknhXhXWcXbHkWlisjfjbNJfSA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00022BF8 File Offset: 0x00020DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358060, XrefRangeEnd = 358066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(sjYknhXhXWcXbHkWlisjfjbNJfSA.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00004E38 File Offset: 0x00003038
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<sjYknhXhXWcXbHkWlisjfjbNJfSA>.NativeClassPtr, ref this));
		}

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_LDBECukoSmFXfHSyoZTXBOjKgIW;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_sjYknhXhXWcXbHkWlisjfjbNJfSA_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_sjYknhXhXWcXbHkWlisjfjbNJfSA_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040004B3 RID: 1203
		[FieldOffset(0)]
		public int LDBECukoSmFXfHSyoZTXBOjKgIW;
	}
}
