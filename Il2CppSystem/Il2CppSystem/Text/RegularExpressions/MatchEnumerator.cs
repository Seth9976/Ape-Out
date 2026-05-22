using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005E RID: 94
	[Serializable]
	public class MatchEnumerator : Object
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x00028718 File Offset: 0x00026918
		// Note: this type is marked as 'beforefieldinit'.
		static MatchEnumerator()
		{
			Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "MatchEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr);
			MatchEnumerator.NativeFieldInfoPtr__matchcoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr, "_matchcoll");
			MatchEnumerator.NativeFieldInfoPtr__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr, "_match");
			MatchEnumerator.NativeFieldInfoPtr__curindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr, "_curindex");
			MatchEnumerator.NativeFieldInfoPtr__done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr, "_done");
			MatchEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_MatchCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr, 100664241);
			MatchEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr, 100664242);
			MatchEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr, 100664243);
			MatchEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr, 100664244);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000287E8 File Offset: 0x000269E8
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchEnumerator(MatchCollection matchcoll)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchcoll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_MatchCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00028834 File Offset: 0x00026A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371041, XrefRangeEnd = 371042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00028870 File Offset: 0x00026A70
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000288B0 File Offset: 0x00026AB0
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000045B2 File Offset: 0x000027B2
		public MatchEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x000288E4 File Offset: 0x00026AE4
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x000045BB File Offset: 0x000027BB
		public unsafe MatchCollection _matchcoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEnumerator.NativeFieldInfoPtr__matchcoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEnumerator.NativeFieldInfoPtr__matchcoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00028914 File Offset: 0x00026B14
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x000045DA File Offset: 0x000027DA
		public unsafe Match _match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEnumerator.NativeFieldInfoPtr__match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEnumerator.NativeFieldInfoPtr__match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00028944 File Offset: 0x00026B44
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x000045F9 File Offset: 0x000027F9
		public unsafe int _curindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEnumerator.NativeFieldInfoPtr__curindex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEnumerator.NativeFieldInfoPtr__curindex)) = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0002896C File Offset: 0x00026B6C
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00004614 File Offset: 0x00002814
		public unsafe bool _done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEnumerator.NativeFieldInfoPtr__done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEnumerator.NativeFieldInfoPtr__done)) = value;
			}
		}

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr__matchcoll;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr__match;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeFieldInfoPtr__curindex;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeFieldInfoPtr__done;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MatchCollection_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
