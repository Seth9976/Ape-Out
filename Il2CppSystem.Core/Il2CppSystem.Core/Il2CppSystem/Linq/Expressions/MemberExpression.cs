using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000019 RID: 25
	public class MemberExpression : Expression
	{
		// Token: 0x06000103 RID: 259 RVA: 0x000078F4 File Offset: 0x00005AF4
		// Note: this type is marked as 'beforefieldinit'.
		static MemberExpression()
		{
			Il2CppClassPointerStore<MemberExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MemberExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr);
			MemberExpression.NativeFieldInfoPtr__Expression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, "<Expression>k__BackingField");
			MemberExpression.NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100663556);
			MemberExpression.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100663557);
			MemberExpression.NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100663558);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00007974 File Offset: 0x00005B74
		public unsafe MemberInfo Member
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000079B4 File Offset: 0x00005BB4
		public unsafe Expression Expression
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000079F4 File Offset: 0x00005BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363657, XrefRangeEnd = 363660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MemberInfo GetMember()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberExpression.NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000025DF File Offset: 0x000007DF
		public MemberExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00007A40 File Offset: 0x00005C40
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000025E8 File Offset: 0x000007E8
		public unsafe Expression _Expression_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberExpression.NativeFieldInfoPtr__Expression_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberExpression.NativeFieldInfoPtr__Expression_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr__Expression_k__BackingField;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_Expression_Public_get_Expression_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0;
	}
}
