using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000154 RID: 340
	[Serializable]
	[StructLayout(2)]
	public struct HSteamPipe
	{
		// Token: 0x06000E55 RID: 3669 RVA: 0x00047BB4 File Offset: 0x00045DB4
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamPipe()
		{
			Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HSteamPipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr);
			HSteamPipe.NativeFieldInfoPtr_m_HSteamPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, "m_HSteamPipe");
			HSteamPipe.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665264);
			HSteamPipe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665265);
			HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665266);
			HSteamPipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665267);
			HSteamPipe.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665268);
			HSteamPipe.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665269);
			HSteamPipe.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamPipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665270);
			HSteamPipe.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665271);
			HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665272);
			HSteamPipe.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100665273);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00047CC0 File Offset: 0x00045EC0
		[CallerCount(0)]
		public unsafe HSteamPipe(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00047CF4 File Offset: 0x00045EF4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 12865, RefRangeEnd = 12872, XrefRangeStart = 12863, XrefRangeEnd = 12865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00047D20 File Offset: 0x00045F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12872, XrefRangeEnd = 12874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00047D64 File Offset: 0x00045F64
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00047D94 File Offset: 0x00045F94
		[CallerCount(0)]
		public unsafe static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00047DE0 File Offset: 0x00045FE0
		[CallerCount(0)]
		public unsafe static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00047E2C File Offset: 0x0004602C
		[CallerCount(0)]
		public unsafe static explicit operator HSteamPipe(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamPipe_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00047E6C File Offset: 0x0004606C
		[CallerCount(0)]
		public unsafe static explicit operator int(HSteamPipe that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00047EAC File Offset: 0x000460AC
		[CallerCount(0)]
		public unsafe bool Equals(HSteamPipe other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00047EEC File Offset: 0x000460EC
		[CallerCount(0)]
		public unsafe int CompareTo(HSteamPipe other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000067A0 File Offset: 0x000049A0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, ref this));
		}

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeFieldInfoPtr_m_HSteamPipe;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamPipe_Int32_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamPipe_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0;

		// Token: 0x040010C2 RID: 4290
		[FieldOffset(0)]
		public int m_HSteamPipe;
	}
}
