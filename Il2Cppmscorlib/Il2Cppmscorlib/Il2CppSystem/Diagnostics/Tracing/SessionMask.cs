using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000520 RID: 1312
	[StructLayout(2)]
	public struct SessionMask
	{
		// Token: 0x06004D52 RID: 19794 RVA: 0x00163E2C File Offset: 0x0016202C
		// Note: this type is marked as 'beforefieldinit'.
		static SessionMask()
		{
			Il2CppClassPointerStore<SessionMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "SessionMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionMask>.NativeClassPtr);
			SessionMask.NativeFieldInfoPtr_m_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, "m_mask");
			SessionMask.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674844);
			SessionMask.NativeMethodInfoPtr_IsEqualOrSupersetOf_Public_Boolean_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674845);
			SessionMask.NativeMethodInfoPtr_get_All_Public_Static_get_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674846);
			SessionMask.NativeMethodInfoPtr_FromId_Public_Static_SessionMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674847);
			SessionMask.NativeMethodInfoPtr_ToEventKeywords_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674848);
			SessionMask.NativeMethodInfoPtr_FromEventKeywords_Public_Static_SessionMask_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674849);
			SessionMask.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674850);
			SessionMask.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674851);
			SessionMask.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674852);
			SessionMask.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, 100674853);
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x00163F38 File Offset: 0x00162138
		[CallerCount(0)]
		public unsafe SessionMask(uint mask = 0U)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00163F6C File Offset: 0x0016216C
		[CallerCount(0)]
		public unsafe bool IsEqualOrSupersetOf(SessionMask m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_IsEqualOrSupersetOf_Public_Boolean_SessionMask_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x00163FAC File Offset: 0x001621AC
		public unsafe static SessionMask All
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_get_All_Public_Static_get_SessionMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x00163FDC File Offset: 0x001621DC
		[CallerCount(0)]
		public unsafe static SessionMask FromId(int perEventSourceSessionId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perEventSourceSessionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_FromId_Public_Static_SessionMask_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x0016401C File Offset: 0x0016221C
		[CallerCount(0)]
		public unsafe ulong ToEventKeywords()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_ToEventKeywords_Public_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x0016404C File Offset: 0x0016224C
		[CallerCount(0)]
		public unsafe static SessionMask FromEventKeywords(ulong m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_FromEventKeywords_Public_Static_SessionMask_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001387 RID: 4999
		public unsafe bool this[int perEventSourceSessionId]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref perEventSourceSessionId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref perEventSourceSessionId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x0016410C File Offset: 0x0016230C
		[CallerCount(0)]
		public unsafe static explicit operator ulong(SessionMask m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SessionMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x0016414C File Offset: 0x0016234C
		[CallerCount(0)]
		public unsafe static explicit operator uint(SessionMask m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionMask.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SessionMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x0001CD29 File Offset: 0x0001AF29
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionMask>.NativeClassPtr, ref this));
		}

		// Token: 0x04003E64 RID: 15972
		private static readonly IntPtr NativeFieldInfoPtr_m_mask;

		// Token: 0x04003E65 RID: 15973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04003E66 RID: 15974
		private static readonly IntPtr NativeMethodInfoPtr_IsEqualOrSupersetOf_Public_Boolean_SessionMask_0;

		// Token: 0x04003E67 RID: 15975
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_SessionMask_0;

		// Token: 0x04003E68 RID: 15976
		private static readonly IntPtr NativeMethodInfoPtr_FromId_Public_Static_SessionMask_Int32_0;

		// Token: 0x04003E69 RID: 15977
		private static readonly IntPtr NativeMethodInfoPtr_ToEventKeywords_Public_UInt64_0;

		// Token: 0x04003E6A RID: 15978
		private static readonly IntPtr NativeMethodInfoPtr_FromEventKeywords_Public_Static_SessionMask_UInt64_0;

		// Token: 0x04003E6B RID: 15979
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

		// Token: 0x04003E6C RID: 15980
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04003E6D RID: 15981
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SessionMask_0;

		// Token: 0x04003E6E RID: 15982
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SessionMask_0;

		// Token: 0x04003E6F RID: 15983
		[FieldOffset(0)]
		public uint m_mask;
	}
}
