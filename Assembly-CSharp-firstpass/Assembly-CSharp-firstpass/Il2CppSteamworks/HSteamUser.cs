using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000155 RID: 341
	[Serializable]
	[StructLayout(2)]
	public struct HSteamUser
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x00047F2C File Offset: 0x0004612C
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamUser()
		{
			Il2CppClassPointerStore<HSteamUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HSteamUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr);
			HSteamUser.NativeFieldInfoPtr_m_HSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, "m_HSteamUser");
			HSteamUser.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665274);
			HSteamUser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665275);
			HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665276);
			HSteamUser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665277);
			HSteamUser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665278);
			HSteamUser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665279);
			HSteamUser.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamUser_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665280);
			HSteamUser.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665281);
			HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665282);
			HSteamUser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100665283);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00048038 File Offset: 0x00046238
		[CallerCount(0)]
		public unsafe HSteamUser(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0004806C File Offset: 0x0004626C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 12865, RefRangeEnd = 12872, XrefRangeStart = 12865, XrefRangeEnd = 12872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00048098 File Offset: 0x00046298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12874, XrefRangeEnd = 12876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000480DC File Offset: 0x000462DC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0004810C File Offset: 0x0004630C
		[CallerCount(0)]
		public unsafe static bool operator ==(HSteamUser x, HSteamUser y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00048158 File Offset: 0x00046358
		[CallerCount(0)]
		public unsafe static bool operator !=(HSteamUser x, HSteamUser y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x000481A4 File Offset: 0x000463A4
		[CallerCount(0)]
		public unsafe static explicit operator HSteamUser(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamUser_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000481E4 File Offset: 0x000463E4
		[CallerCount(0)]
		public unsafe static explicit operator int(HSteamUser that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00048224 File Offset: 0x00046424
		[CallerCount(0)]
		public unsafe bool Equals(HSteamUser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00048264 File Offset: 0x00046464
		[CallerCount(0)]
		public unsafe int CompareTo(HSteamUser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000067B2 File Offset: 0x000049B2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, ref this));
		}

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr_m_HSteamUser;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamUser_Int32_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamUser_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0;

		// Token: 0x040010CE RID: 4302
		[FieldOffset(0)]
		public int m_HSteamUser;
	}
}
