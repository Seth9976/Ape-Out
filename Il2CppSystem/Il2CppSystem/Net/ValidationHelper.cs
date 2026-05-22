using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F1 RID: 241
	public static class ValidationHelper : Object
	{
		// Token: 0x06000D35 RID: 3381 RVA: 0x0004228C File Offset: 0x0004048C
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationHelper()
		{
			Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ValidationHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr);
			ValidationHelper.NativeFieldInfoPtr_EmptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "EmptyArray");
			ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "InvalidMethodChars");
			ValidationHelper.NativeFieldInfoPtr_InvalidParamChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "InvalidParamChars");
			ValidationHelper.NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100665202);
			ValidationHelper.NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100665203);
			ValidationHelper.NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100665204);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00042334 File Offset: 0x00040534
		[CallerCount(0)]
		public unsafe static string MakeStringNull(string stringValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00042370 File Offset: 0x00040570
		[CallerCount(0)]
		public unsafe static bool IsBlankString(string stringValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000423B4 File Offset: 0x000405B4
		[CallerCount(0)]
		public unsafe static bool ValidateTcpPort(int port)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref port;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000073A1 File Offset: 0x000055A1
		public ValidationHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x000423F4 File Offset: 0x000405F4
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x000073AA File Offset: 0x000055AA
		public unsafe static Il2CppStringArray EmptyArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_EmptyArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_EmptyArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0004241C File Offset: 0x0004061C
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x000073BC File Offset: 0x000055BC
		public unsafe static Il2CppStructArray<char> InvalidMethodChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00042444 File Offset: 0x00040644
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x000073CE File Offset: 0x000055CE
		public unsafe static Il2CppStructArray<char> InvalidParamChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_InvalidParamChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_InvalidParamChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_EmptyArray;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_InvalidMethodChars;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_InvalidParamChars;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0;
	}
}
