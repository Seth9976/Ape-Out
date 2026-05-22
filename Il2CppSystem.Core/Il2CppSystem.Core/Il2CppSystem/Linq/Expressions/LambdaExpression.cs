using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000017 RID: 23
	public class LambdaExpression : Expression
	{
		// Token: 0x060000FC RID: 252 RVA: 0x000077C0 File Offset: 0x000059C0
		// Note: this type is marked as 'beforefieldinit'.
		static LambdaExpression()
		{
			Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "LambdaExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr);
			LambdaExpression.NativeFieldInfoPtr__body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, "_body");
			LambdaExpression.NativeMethodInfoPtr_get_Body_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100663555);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00007818 File Offset: 0x00005A18
		public unsafe Expression Body
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_get_Body_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000025AE File Offset: 0x000007AE
		public LambdaExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00007858 File Offset: 0x00005A58
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000025B7 File Offset: 0x000007B7
		public unsafe Expression _body
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LambdaExpression.NativeFieldInfoPtr__body);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LambdaExpression.NativeFieldInfoPtr__body), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr__body;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Public_get_Expression_0;
	}
}
