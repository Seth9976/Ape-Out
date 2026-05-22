using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000040 RID: 64
	public class SecureStringHasher : Object
	{
		// Token: 0x06000313 RID: 787 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
		// Note: this type is marked as 'beforefieldinit'.
		static SecureStringHasher()
		{
			Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "SecureStringHasher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr);
			SecureStringHasher.NativeFieldInfoPtr_hashCodeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "hashCodeDelegate");
			SecureStringHasher.NativeFieldInfoPtr_hashCodeRandomizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "hashCodeRandomizer");
			SecureStringHasher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663674);
			SecureStringHasher.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663675);
			SecureStringHasher.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663676);
			SecureStringHasher.NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663677);
			SecureStringHasher.NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663678);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0001FDA4 File Offset: 0x0001DFA4
		[CallerCount(0)]
		public unsafe SecureStringHasher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390209, XrefRangeEnd = 390210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0001FE40 File Offset: 0x0001E040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390210, XrefRangeEnd = 390216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0001FE90 File Offset: 0x0001E090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390216, XrefRangeEnd = 390217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeOfString(string key, int sLen, long additionalEntropy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390232, RefRangeEnd = 390233, XrefRangeStart = 390217, XrefRangeEnd = 390232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecureStringHasher.HashCodeOfStringDelegate>(intPtr3) : null;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000032FF File Offset: 0x000014FF
		public SecureStringHasher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001FF24 File Offset: 0x0001E124
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00003308 File Offset: 0x00001508
		public unsafe static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecureStringHasher.NativeFieldInfoPtr_hashCodeDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecureStringHasher.HashCodeOfStringDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecureStringHasher.NativeFieldInfoPtr_hashCodeDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0001FF4C File Offset: 0x0001E14C
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0000331A File Offset: 0x0000151A
		public unsafe int hashCodeRandomizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureStringHasher.NativeFieldInfoPtr_hashCodeRandomizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureStringHasher.NativeFieldInfoPtr_hashCodeRandomizer)) = value;
			}
		}

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeDelegate;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeRandomizer;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0;

		// Token: 0x020001F8 RID: 504
		public sealed class HashCodeOfStringDelegate : MulticastDelegate
		{
			// Token: 0x06002A26 RID: 10790 RVA: 0x000BF9A0 File Offset: 0x000BDBA0
			// Note: this type is marked as 'beforefieldinit'.
			static HashCodeOfStringDelegate()
			{
				Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "HashCodeOfStringDelegate");
				SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr, 100663679);
				SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr, 100663680);
				SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr, 100663681);
				SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr, 100663682);
			}

			// Token: 0x06002A27 RID: 10791 RVA: 0x000BFA14 File Offset: 0x000BDC14
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashCodeOfStringDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A28 RID: 10792 RVA: 0x000BFA70 File Offset: 0x000BDC70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 390200, RefRangeEnd = 390202, XrefRangeStart = 390200, XrefRangeEnd = 390200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Invoke(string s, int sLen, long additionalEntropy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002A29 RID: 10793 RVA: 0x000BFADC File Offset: 0x000BDCDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390202, XrefRangeEnd = 390209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002A2A RID: 10794 RVA: 0x000BFB70 File Offset: 0x000BDD70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A2B RID: 10795 RVA: 0x00011CBB File Offset: 0x0000FEBB
			public HashCodeOfStringDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A2C RID: 10796 RVA: 0x00011CC4 File Offset: 0x0000FEC4
			public static implicit operator SecureStringHasher.HashCodeOfStringDelegate(Func<string, int, long, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<SecureStringHasher.HashCodeOfStringDelegate>(A_0);
			}

			// Token: 0x06002A2D RID: 10797 RVA: 0x00011CCC File Offset: 0x0000FECC
			public static SecureStringHasher.HashCodeOfStringDelegate operator +(SecureStringHasher.HashCodeOfStringDelegate A_0, SecureStringHasher.HashCodeOfStringDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SecureStringHasher.HashCodeOfStringDelegate>();
			}

			// Token: 0x06002A2E RID: 10798 RVA: 0x00011CDA File Offset: 0x0000FEDA
			public static SecureStringHasher.HashCodeOfStringDelegate operator -(SecureStringHasher.HashCodeOfStringDelegate A_0, SecureStringHasher.HashCodeOfStringDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SecureStringHasher.HashCodeOfStringDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002017 RID: 8215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002018 RID: 8216
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0;

			// Token: 0x04002019 RID: 8217
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Int64_AsyncCallback_Object_0;

			// Token: 0x0400201A RID: 8218
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}
	}
}
