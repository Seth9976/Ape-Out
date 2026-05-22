using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000159 RID: 345
	public class IntComparer : Object
	{
		// Token: 0x06002941 RID: 10561 RVA: 0x000A65C8 File Offset: 0x000A47C8
		// Note: this type is marked as 'beforefieldinit'.
		static IntComparer()
		{
			Il2CppClassPointerStore<IntComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IntComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntComparer>.NativeClassPtr);
			IntComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntComparer>.NativeClassPtr, 100666561);
			IntComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntComparer>.NativeClassPtr, 100666562);
			IntComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntComparer>.NativeClassPtr, 100666563);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000A6634 File Offset: 0x000A4834
		[CallerCount(0)]
		public unsafe virtual bool Equals(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x000A668C File Offset: 0x000A488C
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000A66D8 File Offset: 0x000A48D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x0001CBF7 File Offset: 0x0001ADF7
		public IntComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
