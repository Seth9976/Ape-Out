using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000018 RID: 24
	public class Expression<TDelegate> : LambdaExpression
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00007888 File Offset: 0x00005A88
		// Note: this type is marked as 'beforefieldinit'.
		static Expression()
		{
			Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000025D6 File Offset: 0x000007D6
		public Expression(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
